using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;
using OuroFramework.Application;
using System.Collections.Generic;

namespace CommentManagement.Application
{
    public class CommentApplication : ICommentApplication
    {
        private readonly ICommentRepository _repository;
        public CommentApplication(ICommentRepository repository)
        {
            _repository = repository;
        }

        public OperationResult Add(AddComment command)
        {
            var operation = new OperationResult();
            var comment = new Comment(command.Name, command.Email, command.Message, command.OwnerRecordId, command.Type, command.ParentId);

            _repository.Create(comment);
            _repository.Save();
            return operation.Succedded();
        }

        public OperationResult Cancel(int id)
        {
            var operation = new OperationResult();
            var comment = _repository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            comment.Cancel();
            _repository.Save();
            return operation.Succedded();
        }

        public OperationResult Confirm(int id)
        {
            var operation = new OperationResult();
            var comment = _repository.Get(id);
            if (comment == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            comment.Confirm();
            _repository.Save();
            return operation.Succedded();
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            return _repository.Search(searchModel);
        }
    }
}
