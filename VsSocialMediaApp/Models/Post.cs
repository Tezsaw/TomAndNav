namespace VsSocialMediaApp.Models
{
    public class Post
    {
        public long Id { get; set; }
        public DateTime Created { get; set; }
        public long PosterId { get; set; }
        public string? Content { get; set; }
    }
}
