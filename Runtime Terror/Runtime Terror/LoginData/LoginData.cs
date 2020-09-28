using Microsoft.AspNetCore.SignalR;
using Runtime_Terror.user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Runtime_Terror.loginData
{
    public class LoginData
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTimeOffset TimeOfLoggingIn { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
