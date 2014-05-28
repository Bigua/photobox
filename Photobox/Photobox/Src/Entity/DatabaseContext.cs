using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoBox.Src.Entity
{
    class DatabaseContext : DataContext
    {
        public static string ConnectionString = "Data Source=isostore:/Photobox.sdf";

        //private Table _album;

        public DatabaseContext(string connectionString)
            : base(connectionString)
        {
            if (!this.DatabaseExists())
                this.CreateDatabase();
        }
    }
}
