using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    class FakeAppUserRepository : IAppUserRepository // cant remember how to fix this, i know it is in the video of this assignment
    {
        private static Dictionary<string, AppUser> AppUsers;
        public FakeAppUserRepository()
        {
            if(AppUsers == null)
            {
                AppUsers = new Dictionary<string, AppUser>();
                AppUsers.Add("JamaeNicole", new AppUser
                {
                    UserName = "JamaeNicole",
                    FirstName = "Jamae",
                    LastName = "Reynolds",
                    Password = "Reynolds1991",
                    EmailAddress = "USMCJamae@gmail.com",
                });
                AppUsers.Add("TravisAlan", new AppUser
                {
                    UserName = "TravisAlan",
                    FirstName = "Travis",
                    LastName = "Heidelberger",
                    Password = "Heidelberger1988",
                    EmailAddress = "TravisAlan24@gmail.com",
                });

            }
        }
        public List<AppUser> GetAll()//*************
        {
            List<AppUser> emps = new List<AppUser>();
            foreach (KeyValuePair<string, AppUser> emp in AppUsers)
            {
                emps.Add(emp.Value);
            }
            return emps;
        }

        public AppUser GetByUserName(string UserName)//*************
        {
            AppUser emp;
            AppUsers.TryGetValue(UserName, out emp);
            return emp;
            
        }

        public bool Login(string UserName, string Password)
        {
            bool AuthenticationStatus = false;
            AppUser emp;
            AppUsers.TryGetValue(UserName, out emp);
            if (emp.Password == Password)
            {
                AuthenticationStatus = true;
                return AuthenticationStatus;
            }
            SetAuthentication(UserName, AuthenticationStatus);
            return AuthenticationStatus;
        }

        public void SetAuthentication(string UserName, bool isAuthenticated)
        {
            AppUser emp = GetByUserName(UserName);
            emp.IsAuthenticated = isAuthenticated;
        }
    }
}
