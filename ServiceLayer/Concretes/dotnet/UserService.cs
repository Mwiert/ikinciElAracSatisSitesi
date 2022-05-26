using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelLayer.Concretes;
using EntitiyLayer.Concretes;

namespace ServiceLayer.Concretes.dotnet
{
    public class UserService:IDisposable
    {
        UserVM userVM = new UserVM();
        public bool IsLoggedIn;
        public bool UserLogin(string username, string password)
        {
            try
            {
                IsLoggedIn = false;
                IsLoggedIn= userVM.LoginUser(username, password);
                return IsLoggedIn;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public User userRegister(User user)
        {
            try
            {
                userVM.userRegister(user);
                return user;

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
