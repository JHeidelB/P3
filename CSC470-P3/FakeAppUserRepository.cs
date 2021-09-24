using System;
using System.Collections.Generic;
using System.Text;

namespace CSC470_P3
{
    class FakeAppUserRepository : IAppUserRepository // cant remember how to fix this, i know it is in the video of this assignment
    {                                               // Travis : Looks like you figured it out, ** good work **
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
        /* Travis:
         * USED "emp" FOR THE INSTANCES OF THE LIST, THIS IS NOT NESSASSARY, 
         * SHOULD HAVE USED SOMETHING MORE MEANINGFUL FOR THIS PROGRAM
         * "emp" WAS FOR EMPLOYEES FROM THE EXAMPLE "should have used "user"
         */
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

        public bool Login(string UserName, string Password) // this looks good, added comments
        {
            bool AuthenticationStatus = false; // sets up false for status
            AppUser emp; // sets and instance of the AppUserClass
            AppUsers.TryGetValue(UserName, out emp); // sets the emp to the Value from the List
            if (emp.Password == Password) // checks the item from list agaist the provided passwork
            {
                AuthenticationStatus = true; // if passwords match set to true
                return AuthenticationStatus; // return the status
            }
            return AuthenticationStatus; // if password does not match, or user does not exist return false
        }

        public void SetAuthentication(string UserName, bool isAuthenticated)
        {
            AppUser emp = GetByUserName(UserName);
            emp.IsAuthenticated = isAuthenticated;
        }
    }
}
