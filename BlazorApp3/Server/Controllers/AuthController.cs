using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Diplom.Shared.Model;
using Microsoft.EntityFrameworkCore;

namespace BlazorApp3.Server.Controllers
{
    [Controller]
    public class AuthController : Controller
    {
        private AppDbContext _context;
        private User currentUser;

        public AuthController(AppDbContext _context)
        {
            this._context = _context;
        }

        [HttpPost("/auth?login={string}&password={string}")]
        public async Task<IActionResult> AuthenticateAsync(string login, string password)
        {
            var user = await _context.Users
                .Include(x => x.Organisation)
                .FirstOrDefaultAsync(x => x.Username == login);
            if (user.Password == password)
            {
                currentUser = user;
            }

            return Redirect("/");
        }

        [HttpGet("/getAuth")]
        public IActionResult IsAuthenticated()
        {
            if (currentUser!= null)
            {
                return StatusCode(200);
            }

            return StatusCode(401);
        }
    }
}
