using Authorizations.Models;
using DocumentFormat.OpenXml.Office2010.Excel;
using Microsoft.AspNetCore.Mvc;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Authorizations.Repositories
{
    public static class UserRepository
    {
        public static User Get(string username, string password)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, Username = "goku", Password = "goku", Role = "manager" });
            users.Add(new User { Id = 2, Username = "vejeta", Password = "vejeta", Role = "employee" });
            users.Add(new User { Id = 3, Username = "kuririn", Password = "kuririn", Role = "tester" });
            return users.Where(x => x.Username.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
