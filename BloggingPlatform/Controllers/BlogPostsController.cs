using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BlogPostsController : ControllerBase
    {
        private readonly ILogger<BlogPostsController> _logger;

        public BlogPostsController(ILogger<BlogPostsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "/api/posts")]
        public IActionResult Get()
        {
            _logger.LogInformation("{api/posts/Get} starting.");
            // get list of BlogPosts
            _logger.LogInformation("{api/posts/Get} end.");
            return Ok();
        }
        [HttpPost(Name = "/api/posts")]
        public IActionResult Post()
        {
            _logger.LogInformation("{api/posts} starting.");
            // create BlogPost
            _logger.LogInformation("{api/posts} end.");
            return Created();
        }
    }
}
