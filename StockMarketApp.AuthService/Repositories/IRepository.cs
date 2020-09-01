using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace StockMarketApp.AuthService.Repositories
{
    public interface IRepository <T>
    {
        bool Signup(T entity);
        Tuple<bool, string> Login(string username, string password);
        bool Logout();
        
        bool UpdateProfile(T entity);
        T GetProfile(ClaimsPrincipal currentUser);
    }
}
