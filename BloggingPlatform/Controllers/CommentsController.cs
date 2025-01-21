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
            return Ok();
        }
        [HttpPost(Name = "/api/posts/{id}/comments")]
        public IActionResult Post(Guid ID, string comments)
        {
            return Created();
        }
    }
}
