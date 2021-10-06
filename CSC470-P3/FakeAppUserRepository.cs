using System;
using System.Collections.Generic;

namespace CSC470_P3
{
    public class FakeAppUserRepository : IAppUserRepository // cant remember how to fix this, i know it is in the video of this assignment
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
                    IsAuthenticated = false
                });
                AppUsers.Add("TravisAlan", new AppUser
                {
                    UserName = "TravisAlan",
                    FirstName = "Travis",
                    LastName = "Heidelberger",
                    Password = "Heidelberger1988",
                    EmailAddress = "TravisAlan24@gmail.com",
                    IsAuthenticated = false
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
            AppUser currentUser;
            try
            {
                currentUser = AppUsers[UserName];
            }
            catch (Exception e)
            {

                currentUser = null;
            }
            return currentUser;
        }

        public bool Login(string UserName, string Password)
        {
            bool AuthenticationStatus = false;
            AppUser emp;
            if (AppUsers.TryGetValue(UserName, out emp))
            {
                AuthenticationStatus = emp.Password == Password;
            }
            return AuthenticationStatus;
        }

        public void SetAuthentication(string UserName, bool isAuthenticated)
        {
            AppUsers[UserName].IsAuthenticated = isAuthenticated;
        }
    }
}
