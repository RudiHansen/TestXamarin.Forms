using System;
using System.Collections.Generic;
using System.Text;

namespace TestXamarin.Forms.Models
{
    public static class UserData
    {
        public static IList<User> Users { get; private set; }

        static UserData()
        {
            Users = new List<User>();

            Users.Add(new User { Name = "Tim", Description = "Tim Parson" });
            Users.Add(new User { Name = "Dan", Description = "Dan Parson" });
            Users.Add(new User { Name = "Christa", Description = "Christa Parson" });
        }

    }
}
