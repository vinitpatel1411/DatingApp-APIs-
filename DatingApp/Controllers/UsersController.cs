using DatingApp.Data;
using DatingApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly DataContext _context;
        private readonly ILogger<UsersController> _logger;
        public UsersController(DataContext Context, ILogger<UsersController> logger)
        {
            _context = Context;
            _logger = logger;
        }

        [HttpGet("")]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return _context.Users.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<AppUser> GetUsers(int id)
        {
            return _context.Users.Find(id);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
