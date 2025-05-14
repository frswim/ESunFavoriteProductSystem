
using ESun.Models;
using ESun.Services;
using Microsoft.AspNetCore.Mvc;

namespace ESun.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _service;
        public ProductController(ProductService service)
        {
            _service = service;
        }

        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUserLikes(string userId)
        {
            var result = await _service.GetUserLikes(userId);
            return Ok(result);
        }

        [HttpGet("like/{id}")]
        public async Task<IActionResult> GetLikeById(int id)
        {
            var result = await _service.GetLikeById(id);
            return result == null ? NotFound() : Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddLike([FromBody] LikeList like)
        {
            await _service.AddLikeAsync(like);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateLike(int id, [FromBody] LikeList like)
        {
            if (id != like.SN) return BadRequest();
            await _service.UpdateLikeAsync(like);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLike(int id)
        {
            await _service.DeleteLikeAsync(id);
            return Ok();
        }
    }
}
