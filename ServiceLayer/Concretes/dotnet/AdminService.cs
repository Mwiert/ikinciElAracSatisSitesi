using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelLayer.Concretes;

namespace ServiceLayer.Concretes.dotnet
{
    public class AdminService
    {
        AdminVM adminVM = new AdminVM();
        public bool isLoggedin;
        public bool AdminLogin(string username,string password)
        {
            try
            {
                isLoggedin = false;
                isLoggedin = adminVM.adminLogin(username, password);
                return isLoggedin;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
