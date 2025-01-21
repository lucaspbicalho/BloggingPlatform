
using BloggingPlatform.Infrasctructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BloggingPlatform.Services
{
    public class BloggingPlatformService : IBloggingPlatformService
    {
        private readonly IBloggingPlatformRepository _bloggingPlatformRepository;

        public BloggingPlatformService(IBloggingPlatformRepository bloggingPlatformRepository)
        {
            _bloggingPlatformRepository = bloggingPlatformRepository;
        }
        public bool Delete(int cod)
        {
            throw new NotImplementedException();
        }

        public BlogPost GetById(Guid id)
        {
            var blogPost = _bloggingPlatformRepository.GetById(id);
            if (blogPost == null)
                throw new Exception("BlogPost not found.");

            return blogPost;
        }

        public List<BlogPost> List()
        {
            return _bloggingPlatformRepository.List();
        }

        public void Save(BlogPost BlogPostVM)
        {
            _bloggingPlatformRepository.Save(BlogPostVM);
        }

        public void SaveComment(Comment comment)
        {
            _bloggingPlatformRepository.SaveComment(comment);
        }

        public void Update(BlogPost blogPost)
        {
            _bloggingPlatformRepository.Update(blogPost);
        }
    }
}
