using BloggingPlatform.Services;
using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostsController : ControllerBase
    {
        private readonly BloggingPlatformService _bloggingPlatformService;
        private readonly ILogger<BlogPostsController> _logger;

        public BlogPostsController(BloggingPlatformService bloggingPlatformService, ILogger<BlogPostsController> logger)
        {
            this._bloggingPlatformService = bloggingPlatformService;
            _logger = logger;
        }

        [HttpGet(Name = "/api/posts")]
        public IActionResult Get()
        {
            _logger.LogInformation("{api/posts/Get} starting.");
            // get list of BlogPosts
            var blogPosts = _bloggingPlatformService.List();
            _logger.LogInformation("{api/posts/Get} end.");
            return Ok(blogPosts);
        }

        [HttpGet("{id}", Name = "/api/posts/{id}")]
        public IActionResult Get(Guid id)
        {
            _logger.LogInformation("{api/posts/id} starting.");
            // get BlogPost
            var blogPost = _bloggingPlatformService.GetById(id);
            _logger.LogInformation("{api/posts/id} end.");
            return Ok(blogPost);
        }
        [HttpPost(Name = "/api/posts")]
        public IActionResult Post([FromBody] BlogPost BlogPostVM)
        {
            _logger.LogInformation("{api/posts} starting.");
            // create BlogPost
            _bloggingPlatformService.Save(BlogPostVM);
            _logger.LogInformation("{api/posts} end.");
            return Created();
        }
    }
}
