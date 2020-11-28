using Blazored.LocalStorage;
using Diplom.Shared.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Controllers
{
    public class Authenticator
    {
        private IDbContextFactory<AppDbContext> _dbContextFactory;
        private ILocalStorageService _localStorage;

        public Authenticator(IDbContextFactory<AppDbContext> dbContextFactory, ILocalStorageService localStorageService) 
        {
            _dbContextFactory = dbContextFactory;
            _localStorage = localStorageService;
        }

        public async Task<bool> Authenticate(string username, string password)
        {
            using (var _context = _dbContextFactory.CreateDbContext())
            {
                var user = await _context.Users.FindAsync(username);

                if (user != null && user.Password == password)
                {
                    await _localStorage.SetItemAsync("user",_context.Users
                                                            .Include(x=>x.Organisation)
                                                            .FirstOrDefault(x => x.Username == username));
                    return true;
                }
                return false;
            }
        }

        public async Task<bool> UnAuthenticate() 
        {
            if (await _localStorage.ContainKeyAsync("user"))
            {
                await _localStorage.RemoveItemAsync("user");
                return true;
            }
            return false;
        }
    }
}
