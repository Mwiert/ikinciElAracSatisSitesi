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
            connectionString=DbHelper.GetInstance();
            loginStatus = false;
        }
        public User addUser(User user)
        {
            try
            {
                var query = new StringBuilder();

                query.Append("INSERT into UserTable ([Ad], [Soyad], [Email], [Password]) values (@Ad, @Soyad, @Email, @Password)");

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

                        DbHelper.AddParameter(command, "@Ad", user.Ad, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(command, "@Soyad", user.Soyad, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(command, "@Email", user.Email, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(command, "@Password", user.Password, DbType.String, ParameterDirection.Input);

                        command.ExecuteNonQuery();
                    }
                }
                return user;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public bool UserLogin(string username, string password)
        {
            try
            {
                var query = new StringBuilder();

                query.Append("SELECT *From UserTable Where Email = @Email AND Password = @Password");

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

                        DbHelper.AddParameter(command, "@Email", username, DbType.String, ParameterDirection.Input);
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

                        DbHelper.AddParameter(cmd, "@Ad",user.Ad ,DbType.String,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Soyad", user.Soyad, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Email", user.Email, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Password", user.Password, DbType.String, ParameterDirection.Input);
                        
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
            GC.SuppressFinalize(true);
        }
    }
}
