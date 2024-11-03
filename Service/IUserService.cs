using Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface IUserService
    {
        Task<UserResponseModel> LoginAsync(string username, string password);
        Task<bool> RegisterAsync(RegisterRequestModel model);
        void Logout();
    }
}
