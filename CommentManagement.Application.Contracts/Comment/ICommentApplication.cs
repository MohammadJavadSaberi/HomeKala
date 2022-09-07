using OuroFramework.Application;
using System.Collections.Generic;

namespace CommentManagement.Application.Contracts.Comment
{
    public interface ICommentApplication
    {
        OperationResult Add(AddComment command);
        OperationResult Confirm(int id);
        OperationResult Cancel(int id);
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
