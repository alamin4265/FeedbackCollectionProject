using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App_Core.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace App_RestAPI.Controllers
{
    [Route("api/posts")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly AppDbContext dbContext;

        public PostController(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAllPost()
        {
            var data = dbContext.BlogPost.Include(i => i.Feedbacks).ToList();
            return Ok(data);
        }

        [HttpGet("{name}", Name = "Get")]
        public IActionResult GetbyPostName(string name)
        {
            var data = dbContext.BlogPost.Include(i => i.Feedbacks).Where(p => p.Name.Contains(name)).ToList();
            return Ok(data);
        }
    }
}