using EntitiyLayer.Concretes;
using Helpers.Concretes.Helpers.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccesLayer.Concretes.UserCrud
{
    public class UserCRUD : IDisposable
    {
        public string connectionString { get; set; }
        public bool loginStatus { get; set; }

        public UserCRUD()
        {
            connectionString = DbHelper.getConnectionString();
            loginStatus = false;
        }
        public User AracEkle(User user)
        {
            try
            {
                var query = new StringBuilder();
                query.Append("Insert into UserTable ([Ad], [Soyad], [Email], [Password]) values (@Ad, @Soyad, @Email, @Password)");

                string cmdTxt;
                cmdTxt = query.ToString();

                using (var dbCon = new SqlConnection(connectionString))
                {
                    using (var cmd = new SqlCommand(cmdTxt))
                    {
                        if (dbCon.State != ConnectionState.Open)
                        {
                            dbCon.Open();
                        }

                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        
                        cmd.ExecuteNonQuery();

                    }
                }
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
