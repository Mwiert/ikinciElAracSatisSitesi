﻿using DataAccesLayer.Concretes.UserCrud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLayer.Concretes
{
    public class UserVM
    {
        public bool logincheck;
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
    }
}
