using Microsoft.AspNetCore.Mvc;
using VsSocialMediaApp.Models;

namespace VsSocialMediaApp.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public PostsController(ApplicationDBContext context)
        {
            _context = context;
        }

        public List<Post> GetRecentPosts(int count)
        {
            var allPosts = _context.Posts.ToList();

            allPosts.Sort(delegate(Post x, Post y)
            {
                return x.Created.CompareTo(y.Created);
            });

            return allPosts.Take(count).ToList();
        }
        public List<Post> GetLikedPosts(int count)
        {
            var allPosts = _context.Posts.ToList();

            allPosts.Sort(delegate(Post x, Post y)
            {
                return x.Likes.CompareTo(y.Likes);
            });

            return allPosts.Take(count).ToList();
        }

        public Account? GetAccountFromId(ulong id)
        {
            return _context.Accounts.ToList().Find(a => a.Id == id);
        }
    }
}
