using System;
using System.Collections.Generic;
using System.Text;

namespace NexusExample.Core
{
    public class UserManager : IUserManager
    {
        public string Add()
        {
            return "User Added";
        }

        public string Delete()
        {
            return "User Deleted";
        }
    }
}
