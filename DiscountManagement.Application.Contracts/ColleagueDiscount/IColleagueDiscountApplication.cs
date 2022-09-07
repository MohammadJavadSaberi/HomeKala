using OuroFramework.Application;
using System.Collections.Generic;

namespace DiscountManagement.Application.Contracts.ColleagueDiscount
{
    public interface IColleagueDiscountApplication
    {
        OperationResult Create(CreateColleagueDiscount command);
        OperationResult Edit(EditColleagueDiscount command);
        OperationResult Active(int id);
        OperationResult DeActive(int id);
        EditColleagueDiscount GetDetails(int id);
        List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel);
    }
}
