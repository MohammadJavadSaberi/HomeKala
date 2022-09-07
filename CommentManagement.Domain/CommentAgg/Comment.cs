using OuroFramework.Domain;
using System.Collections.Generic;

namespace CommentManagement.Domain.CommentAgg
{
    public class Comment : EntityBase<int>
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }
        public bool IsConfirmed { get; private set; }
        public int OwnerRecordId { get; private set; }
        public int Type { get; private set; }
        public int ParentId { get; private set; }
        public Comment Parent { get; private set; }
        public List<Comment> Childern { get; private set; }

        public Comment(string name, string email, string message, int ownerRecordId, int type, int parentId)
        {
            Name = name;
            Email = email;
            Message = message;
            OwnerRecordId = ownerRecordId;
            Type = type;
            ParentId = parentId;
        }
        public void Confirm()
        {
            IsConfirmed = true;
        }
        public void Cancel()
        {
            IsConfirmed = false;
        }
    }
}
