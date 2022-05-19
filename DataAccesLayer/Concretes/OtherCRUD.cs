using Helpers.Concretes.Helpers.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concretes
{
    public class OtherCRUD
    {
        public string connectionString { get; set; }
        public bool loginStatus { get; set; }
        public OtherCRUD()
        {
            connectionString = DbHelper.getConnectionString();
            loginStatus = false;
        }
    }
}
