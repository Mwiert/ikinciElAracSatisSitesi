using Helpers.Concretes.Helpers.DBHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            connectionString = DbHelper.GetInstance();
            //connectionString= DbHelper.getConnectionString();
            loginStatus = false;
        }
        public bool adminLogin(string username, string password)
        {
            try
            {
                var query = new StringBuilder();

                query.Append("SELECT *From Admin Where Username = @Username AND Password = @Password");

                string commandText = query.ToString();

                using (var dbConnection = new SqlConnection(connectionString))
                {
                    if (dbConnection.State != ConnectionState.Open)
                    {
                        dbConnection.Open();
                    }

                    using (var command = new SqlCommand(commandText))
                    {
                        command.Connection = dbConnection;

                        DbHelper.AddParameter(command, "@Username", username, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(command, "@Password", password, DbType.String, ParameterDirection.Input);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    loginStatus = true;
                                }
                            }
                        }
                    }
                }
                return loginStatus;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(true);
        }
    }
}
