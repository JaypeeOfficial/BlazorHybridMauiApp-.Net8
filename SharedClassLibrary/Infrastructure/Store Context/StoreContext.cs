using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SharedClassLibrary.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedClassLibrary.Infrastructure.Store_Context
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options) { }
        public virtual DbSet<User> Users
        {
            get;
            set;
        }


    }
}
