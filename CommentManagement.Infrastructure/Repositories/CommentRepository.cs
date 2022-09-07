using CommentManagement.Application.Contracts.Comment;
using CommentManagement.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using OuroFramework.Application;
using OuroFramework.Infrastructure;
using System.Collections.Generic;
using System.Linq;

namespace CommentManagement.Infrastructure.Repositories
{
    public class CommentRepository : RepositoryBase<int, Comment>, ICommentRepository
    {
        private readonly CommentContext _context;
        public CommentRepository(CommentContext context) : base(context)
        {
            _context = context;
        }

        public List<CommentViewModel> Search(CommentSearchModel searchModel)
        {
            var query = _context.Comments.Select(p => new CommentViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Message = p.Message,
                Email = p.Email,
                OwnerRecordId = p.OwnerRecordId,
                Type = p.Type,
                IsConfirm = p.IsConfirmed,
                CreationTime = p.CreationTime.ToFarsi()
            }).AsNoTracking();

            if (!string.IsNullOrWhiteSpace(searchModel.Name))
                query = query.Where(p => p.Name.Contains(searchModel.Name));

            if (!string.IsNullOrWhiteSpace(searchModel.Email))
                query = query.Where(p => p.Email.Contains(searchModel.Email));

            return query.OrderByDescending(p => p.Id).ToList();
        }
    }
}
