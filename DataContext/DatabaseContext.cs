using Microsoft.EntityFrameworkCore;
using WebPACS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPACS.Areas.Administrator.Models;
using WebPACS.Areas.Customer.Models;
using WebPACS.Areas.DCCB.Models;
using WebPACS.Areas.Deposit.Models;
using WebPACS.Areas.FinYear_ROI.Models;
using WebPACS.Areas.SCB.Models;

namespace WebPACS.DataContext
{
    public class Databasecontext : DbContext
    {
        public DbSet<WebPACS.Areas.Administrator.Models.AdministratorModel> administratorModel { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-N9I077O\SQLEXPRESS;Initial Catalog=DataManagementPACS; Integrated Security=True");
        }

        public DbSet<WebPACS.Areas.Customer.Models.Customer> customerModel { get; set; }

        public DbSet<WebPACS.Areas.DCCB.Models.DCCB> DCCBmodel { get; set; }

        public DbSet<WebPACS.Areas.Deposit.Models.Deposit> DepositModel { get; set; }

        public DbSet<WebPACS.Areas.FinYear_ROI.Models.FinYear_ROI> FinYear_ROImodel { get; set; }

        public DbSet<WebPACS.Areas.SCB.Models.SCB> SCBmodel { get; set; }
    }
}
