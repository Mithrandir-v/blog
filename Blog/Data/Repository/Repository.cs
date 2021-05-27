using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;

namespace Blog.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }

        public Post GetPost(int id)
        {
            return _context.Posts.FirstOrDefault(p => p.Id == id);
        }

        public List<Post> GetAllPosts()
        {
            return _context.Posts.ToList();
        }

        public void RemovePost(int id)
        {
            _context.Posts.Remove(GetPost(id));
        }

        public void UpdatePost(Post post)
        {
            _context.Posts.Update(post);
        }

        public void AddPost(Post post)
        {
            _context.Posts.Add(post);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return  await _context.SaveChangesAsync() > 0;
        }
    }
}
