using Microsoft.AspNetCore.Mvc;

namespace BloggingPlatform.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CommentsController : ControllerBase
    {
        private readonly ILogger<CommentsController> _logger;

        public CommentsController(ILogger<CommentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "/api/posts/{id}")]
        public IActionResult Get(Guid ID)
        {
            _logger.LogInformation("{api/posts/id} starting.");
            // get Comment
            _logger.LogInformation("{api/posts/id} end.");
            return Ok();
        }
        [HttpPost(Name = "/api/posts/{id}/comments")]
        public IActionResult Post(Guid ID, string comments)
        {
            _logger.LogInformation("{api/posts/id/comments} starting.");
            // create Comment
            _logger.LogInformation("{api/posts/id/comments} end.");
            return Created();
        }
    }
}
