using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SulsApp.Services
{
    public interface IUsersService
    {
        void CreateUser(string username, string email, string password);

        string GetUserId(string username, string password);

        void ChangePassword(string username, string newPassword);

        bool IsUsernameUsed(string username);

        bool IsEmaiUsed(string email);

        int CountUsers();
    }
}
