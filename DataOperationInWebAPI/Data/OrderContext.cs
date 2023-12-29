using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataOperationInWebAPI.Data;

namespace DataOperationInWebAPI.Data
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\GitHub\SyncfusionExamples\Grid\Data-operation-in-webapi\grid1\DataOperationInWebAPI\App_Data\NORTHWND.MDF;Integrated Security=True");
            }
        }
    }
 
}
