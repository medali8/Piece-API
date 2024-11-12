using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piece.Data;

namespace Piece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiecesController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;
        public PiecesController(ApplicationDbContext Context)
        {
            this.dbContext = Context;
        }
        [HttpGet]
        public IActionResult GetAllArticles()
        {
            var AllArticles = this.dbContext.piece.ToList();
            return Ok(AllArticles);
        }

    }
}
