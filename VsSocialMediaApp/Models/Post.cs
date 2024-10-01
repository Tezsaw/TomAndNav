namespace VsSocialMediaApp.Models
{
    public class Post
    {
        public ulong Id { get; set; }
        public DateTime Created { get; set; }
        public ulong PosterId { get; set; }
        public string? Content { get; set; }
        public List<Account>? UsersWhoLiked { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
