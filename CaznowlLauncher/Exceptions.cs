using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaznowlLauncher
{
    public class BadLoginException : Exception
    {
        public string Username { get; set; }
        public BadLoginException(string Username, string msg = "Invalid Username/Password for user: ") : base(msg + Username) { this.Username = Username; }
    }

    public class UserNotPremiumException : Exception
    {
        public string Username { get; set; }
        public UserNotPremiumException(string Username, string msg = "User is not premium: ") : base(msg + Username) { this.Username = Username; }
    }
    public class UserMigratedException : Exception
    {
        public string Username { get; set; }
        public UserMigratedException(string Username, string msg = "Account is migrated use the Email as username. Account username: ") : base(msg + Username) { this.Username = Username; }
    }
}
