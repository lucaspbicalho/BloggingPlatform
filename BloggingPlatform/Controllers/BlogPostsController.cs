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
            return Ok();
        }
        [HttpPost(Name = "/api/posts")]
        public IActionResult Post()
        {
            return Created();
        }
    }
}
