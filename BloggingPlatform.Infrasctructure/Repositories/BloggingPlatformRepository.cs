using BloggingPlatform.Infrasctructure.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggingPlatform.Infrasctructure.Repositories
{
    public class BloggingPlatformRepository : IBloggingPlatformRepository
    {
        private readonly BloggingPlatformDbContext _context;
        public BloggingPlatformRepository(BloggingPlatformDbContext context)
        {
            _context = context;
        }
        public bool Delete(int cod)
        {
            throw new NotImplementedException();
        }

        public BlogPost GetById(Guid id)
        {
            return _context.BlogPosts
                .Include(c => c.Comments)
                .Where(b => b.Id == id)
                .FirstOrDefault();
        }

        public List<BlogPost> List()
        {
            return _context.BlogPosts
             .Include(c => c.Comments)
             .ToList();
        }

        public void Save(BlogPost BlogPostVM)
        {
            _context.BlogPosts.Add(BlogPostVM);
            _context.SaveChanges();
        }
        public void SaveComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void Update(BlogPost blogPost)
        {
            _context.BlogPosts.Update(blogPost);
            _context.SaveChanges();
        }
    }
}
