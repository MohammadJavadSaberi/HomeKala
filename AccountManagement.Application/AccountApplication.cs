using AccountManagement.Application.Contracts.Account;
using AccountManagement.Domain.AccountAgg;
using OuroFramework.Application;
using System.Collections.Generic;

namespace AccountManagement.Application
{
    public class AccountApplication : IAccountApplication
    {
        private readonly IFileUploader _uploader;
        private readonly IPasswordHasher _passwordHasher;
        private readonly IAccountRepository _accountRepository;
        private readonly IAuthHelper _authHelper;
        public AccountApplication(IAccountRepository accountRepository, IPasswordHasher passwordHasher, IFileUploader uploader, IAuthHelper authHelper)
        {
            _accountRepository = accountRepository;
            _passwordHasher = passwordHasher;
            _uploader = uploader;
            _authHelper = authHelper;
        }

        public OperationResult Create(CreateAccount command)
        {
            var operation = new OperationResult();
            if (_accountRepository.Exists(p => p.UserName == command.UserName || p.Mobile == command.Mobile))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var password = _passwordHasher.Hash(command.PassWord);
            var account = new Account(command.FullName, command.UserName, command.PassWord, command.Mobile, _uploader.Upload(command.ProfilePicture, "ProfilePictures"), command.RoleId);

            _accountRepository.Create(account);
            _accountRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditAccount command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (_accountRepository.Exists(p => (p.UserName == command.UserName || p.Mobile == command.Mobile) && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            account.Edit(command.FullName, command.UserName, command.Mobile, _uploader.Upload(command.ProfilePicture, "ProfilePictures"), command.RoleId);
            _accountRepository.Save();
            return operation.Succedded();
        }

        public EditAccount GetDetails(int id)
        {
            return _accountRepository.GetDetails(id);
        }

        public OperationResult ChangePassword(ChangePassword command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.Get(command.Id);
            if (account == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (command.Password != command.RePassword)
                return operation.Failed(ApplicationMessages.PasswordNotMatch);

            var password = _passwordHasher.Hash(command.Password);
            account.ChangePassword(password);
            _accountRepository.Save();
            return operation.Succedded();
        }

        public List<AccountViewModel> Search(AccountSearchModel searchModel)
        {
            return _accountRepository.Search(searchModel);
        }

        public OperationResult Login(Login command)
        {
            var operation = new OperationResult();
            var account = _accountRepository.GetBy(command.Username);
            if (account == null)
                return operation.Failed(ApplicationMessages.LoginPassWrong);

            var checkPass = _passwordHasher.Check(account.PassWord, command.Password);
            if (!checkPass.Verified)
                return operation.Failed(ApplicationMessages.LoginPassWrong);

            var auth = new AuthViewModel(account.Id, account.RoleId, account.FullName, account.UserName, account.Mobile);
            _authHelper.Signin(auth);
            return operation.Succedded();
        }

        public OperationResult Logout()
        {
            var operation = new OperationResult();
            _authHelper.SignOut();
            return operation.Succedded();
        }
    }
}
