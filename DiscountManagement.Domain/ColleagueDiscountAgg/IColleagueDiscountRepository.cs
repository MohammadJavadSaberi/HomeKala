using DiscountManagement.Application.Contracts.ColleagueDiscount;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace DiscountManagement.Domain.ColleagueDiscountAgg
{
    public interface IColleagueDiscountRepository : IRepositoryBase<int, ColleagueDiscount>
    {
        EditColleagueDiscount GetDetails(int id);
        List<ColleagueDiscountViewModel> Search(ColleagueDiscountSearchModel searchModel);
    }
}
