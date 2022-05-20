using DataAccesLayer.Concretes.AdminCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLayer.Concretes
{
    public class AdminVM
    {
        public bool adminLogin(string username, string password)
        {
            try
            {
                bool loginStatus = false;

                using (var repository = new AdminCRUD())
                {
                    loginStatus = repository.adminLogin(username, password);
                }
                return loginStatus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
