using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    interface IAppUserRepository
    {
        bool Login(string UserName, string Password);
        List<AppUser> GetAll();
        void SetAuthentication(string UserName, bool isAuthenticated);
        AppUser GetByUserName(string UserName);
    }
}
