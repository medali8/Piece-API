using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Piece.Data;
using System.Net.Http;
using System.Text.Json;
using System.Text;
using System.Threading.Tasks;
using System;
using Microsoft.EntityFrameworkCore;

namespace Piece.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PiecesController : ControllerBase
    {
        private readonly ApplicationDbContext _dbContext;
        [HttpGet]
        public IActionResult GetAllPieces()
        {
            var allArticles = _dbContext.piece.ToList();
            return Ok(allArticles);
        }

        public PiecesController(ApplicationDbContext context)
        {
            _dbContext = context;
        }
        [HttpPost("getPiecesById")]
        public IActionResult GetPiecesById(long id)
        {
            var articles = _dbContext.piece.Where(a => a.ArticleBudgetaireID == id).ToList();
            if (articles == null)
            {
                return NotFound();
            }

            return Ok(articles);
        }
    }
}
