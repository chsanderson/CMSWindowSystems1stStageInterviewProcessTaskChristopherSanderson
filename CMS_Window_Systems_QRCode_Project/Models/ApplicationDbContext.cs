using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.Design; 

namespace CMS_Window_Systems_QRCode_Project.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base (options)
        { }
            public DbSet<Production> productions { get; set; }
            public DbSet<Heading> headings { get; set; }
            public DbSet<QRTable> qRTables { get; set; }
    }
}
