using CommentManagement.Application.Contracts.Comment;
using OuroFramework.Domain;
using System.Collections.Generic;

namespace CommentManagement.Domain.CommentAgg
{
    public interface ICommentRepository : IRepositoryBase<int, Comment>
    {
        List<CommentViewModel> Search(CommentSearchModel searchModel);
    }
}
