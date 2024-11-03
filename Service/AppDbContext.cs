using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Service;

public class APPDbContext : DbContext
{
    public APPDbContext(DbContextOptions<APPDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}
