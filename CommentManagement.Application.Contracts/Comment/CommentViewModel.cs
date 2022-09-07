namespace CommentManagement.Application.Contracts.Comment
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }
        public string Email { get; set; }
        public int OwnerRecordId { get; set; }
        public int Type { get; set; }
        public bool IsConfirm { get; set; }
        public string CreationTime { get; set; }
    }
}
