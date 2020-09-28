using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Runtime_Terror.loginData;
using Microsoft.AspNetCore.SignalR;
using Runtime_Terror.user;

namespace Runtime_Terror.Datacontext
{
    public class DataContext : DbContext 
    {

        public DataContext(DbContextOptions<DataContext> options): base(options)
        {



        }

        public DbSet<LoginData> LoginDatas { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
