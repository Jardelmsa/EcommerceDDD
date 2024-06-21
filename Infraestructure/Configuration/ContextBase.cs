using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Configuration
{
    public class ContextBase:DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options): base(options)
        {
        }

        public DbSet<Produto>Produto{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(string.Empty);
                base.OnConfiguring(optionsBuilder);
            }
        }

        private string GetStringConnectionConfig()
        {
            string strCon = "Data Source=DESKTOP-QO629LP\\DESENVOLVIMENTO;Initial Catalog=DDD_ECOMMERCE; Integrated Security=False; User ID=root; Password=root;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";
            return strCon;
        }
    }
}
