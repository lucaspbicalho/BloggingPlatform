using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly BloggingPlatformService _bloggingPlatformService;
        private readonly ILogger<CommentsController> _logger;

        public CommentsController(BloggingPlatformService bloggingPlatformService, ILogger<CommentsController> logger)
        {
            this._bloggingPlatformService = bloggingPlatformService;
            _logger = logger;
        }
   
        [HttpPost("{id}", Name = "/api/posts/{id}/comments")]
        public IActionResult Post(Guid id, string comments)
        {
            _logger.LogInformation("{api/posts/id/comments} starting.");
            _logger.LogInformation("{api/posts/id/comments} Check if Blog exist starting.");
            var blogPost = _bloggingPlatformService.GetById(id);
            _logger.LogInformation("{api/posts/id/comments} Check if Blog exist end." , blogPost);
            // create Comment
            Comment comment = new Comment { Id = Guid.NewGuid(), Message = comments };
            _bloggingPlatformService.SaveComment(comment);
            blogPost.Comments.Add(comment);
            _bloggingPlatformService.Update(blogPost);
            _logger.LogInformation("{api/posts/id/comments} end.");
            return Created();
        }
    }
}
