using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Repo;

public interface IUserRepo
{
    Task<User> GetUserByUsernameAsync(string username);
}
