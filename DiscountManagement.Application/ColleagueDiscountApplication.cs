using DiscountManagement.Application.Contracts.ColleagueDiscount;
using DiscountManagement.Domain.ColleagueDiscountAgg;
using OuroFramework.Application;
using System;
using System.Collections.Generic;

namespace DiscountManagement.Application
{
    public class ColleagueDiscountApplication : IColleagueDiscountApplication
    {
        private readonly IColleagueDiscountRepository _colleagueDiscountRepository;
        public ColleagueDiscountApplication(IColleagueDiscountRepository colleagueDiscountRepository)
        {
            _colleagueDiscountRepository = colleagueDiscountRepository;
        }

        public OperationResult Create(CreateColleagueDiscount command)
        {
            var operation = new OperationResult();
            if (_colleagueDiscountRepository.Exists(
                    p => p.DiscountRate == command.DiscountRate && p.ProductId == command.ProductId))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            var colleagueDiscount = new ColleagueDiscount(command.DiscountRate, command.ProductId);

            _colleagueDiscountRepository.Create(colleagueDiscount);
            _colleagueDiscountRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Edit(EditColleagueDiscount command)
        {
            var operation = new OperationResult();
            var colleagueDiscount = _colleagueDiscountRepository.Get(command.Id);
            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            if (_colleagueDiscountRepository.Exists(
                    p => p.DiscountRate == command.DiscountRate && p.ProductId == command.ProductId && p.Id != command.Id))
                return operation.Failed(ApplicationMessages.DuplicatedRecord);

            colleagueDiscount.Edit(command.DiscountRate, command.ProductId);
            _colleagueDiscountRepository.Save();
            return operation.Succedded();
        }

        public OperationResult Active(int id)
        {
            var operation = new OperationResult();
            var colleagueDiscount = _colleagueDiscountRepository.Get(id);
            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            colleagueDiscount.Active();
            _colleagueDiscountRepository.Save();
            return operation.Succedded();
        }

        public OperationResult DeActive(int id)
        {
            var operation = new OperationResult();
            var colleagueDiscount = _colleagueDiscountRepository.Get(id);
            if (colleagueDiscount == null)
                return operation.Failed(ApplicationMessages.NotFoundRecord);

            colleagueDiscount.DeActive();
            _colleagueDiscountRepository.Save();
            return operation.Succedded();
        }

        public EditColleagueDiscount GetDetails(int id)
        {
            return _colleagueDiscountRepository.GetDetails(id);
        }

        public List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel)
        {
            return _colleagueDiscountRepository.Search(searchModel);
        }
    }
}
