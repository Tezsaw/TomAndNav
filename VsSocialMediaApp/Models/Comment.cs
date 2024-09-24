namespace VsSocialMediaApp.Models
{
    public class Comment
    {
        public ulong Id { get; set; }
        public DateTime Created { get; set; }
        public ulong PosterId { get; set; }
        public string? Content { get; set; }
        public uint Likes { get; set; }
        public ulong ParentPostId { get; set; }
    }
}
