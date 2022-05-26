using DataAccesLayer.Concretes.UserCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Concretes;

namespace ViewModelLayer.Concretes
{
    public class UserVM:IDisposable
    {
        public bool logincheck;
        public User userRegister(User user)
        {
            try
            {
                User user1 = new User();
                using (var repo = new UserCRUD())
                {
                    user1= repo.addUser(user);
                }
                return user1;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool LoginUser(string username,string password)
        {
            logincheck = false;
            try
            {
                using (var repo = new UserCRUD())
                {
                    logincheck = repo.UserLogin(username,password);
                }
                return logincheck;
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
