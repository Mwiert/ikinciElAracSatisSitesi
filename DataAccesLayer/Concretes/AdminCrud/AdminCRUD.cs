using Helpers.Concretes.Helpers.DBHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concretes.AdminCrud
{
    public class AdminCRUD:IDisposable
    {
        public string connectionString { get; set; }
        public bool loginStatus { get; set; }
        public AdminCRUD()
        {
            connectionString= DbHelper.getConnectionString();
            loginStatus = false;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
