using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace MVVMAtm_ASSIGN.Models
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public  class AtmContext: DbContext
    {
        public AtmContext() : base("name= connstr")
        {
           
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }


    }
}
