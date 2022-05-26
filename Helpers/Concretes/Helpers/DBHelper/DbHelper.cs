using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Helpers.Concretes.Helpers.DBHelper
{
    public class DbHelper
    {
        private DbHelper()
        {
            
        }
        private static string Instance;
        public static string GetInstance()
        {
            if (Instance == null)
            {
                Instance =  getConnectionString();
            }
            return Instance;
        }
        private static string getConnectionString()
        {
            string connectionString = "Data Source=MWIERT;Initial Catalog=ikinicElarac;Integrated Security=True";
            return connectionString;

        }
        public static void AddParameter(DbCommand command, string parameterName,
                                              object parameterValue, DbType parameterType,
                                              ParameterDirection direction)
        {
            DbParameter parameter = command.CreateParameter();

            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            parameter.DbType = parameterType;
            parameter.Direction = direction;

            command.Parameters.Add(parameter);
        }
    }
}
