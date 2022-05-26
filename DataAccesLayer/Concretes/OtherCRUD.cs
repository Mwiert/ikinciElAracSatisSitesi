using EntitiyLayer.Concretes;
using Helpers.Concretes.Helpers.DBHelper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccesLayer.Concretes
{
    public class OtherCRUD:IDisposable 
    {
        public string connectionString { get; set; }
        public bool loginStatus { get; set; }
        public OtherCRUD()
        {
            connectionString = DbHelper.GetInstance();
            loginStatus = false;
        }
        public List<Arac> AracList()
        {
            try
            {
                Arac arac = new Arac();
                List<Arac> list = new List<Arac>();

                var query = new StringBuilder();

                query.Append("Select * from AracBilgileri");
                string cmdTxt = query.ToString();

                using (var DbCon = new SqlConnection(connectionString))
                {
                    using(var cmd = new SqlCommand(cmdTxt))
                    {
                        if(DbCon.State != ConnectionState.Open)
                        {
                            DbCon.Open();
                        }
                        cmd.Connection = DbCon;
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    arac.AracId = (int)reader["AracId"];
                                    //arac.AracResim = (string)reader["AracResim"];
                                    arac.AracTuru = (string)reader["AracTuru"];
                                    arac.OnayDurumu = (bool)reader["OnayDurumu"];
                                    arac.YakıtTuru = (string)reader["YakıtTuru"];
                                    arac.ParkSensoru = (bool)reader["ParkSensoru"];

                                    arac.ParkSensoru = (bool)reader["ParkSensoru"];
                                    arac.CamTavan = (bool)reader["CamTavan"];
                                    arac.KatlanılabilirAyna = (bool)reader["KatlanılabilirAyna"];
                                    arac.Km = (int)reader["Km"];

                                    arac.Marka = (string)reader["Marka"];
                                    arac.MKS = (bool)reader["MKS"];
                                    arac.MotorHacmi = (int)reader["MotorHacmi"];
                                    arac.SatisFiyati = (int)reader["SatisFiyati"];
                                    arac.SisFari = (bool)reader["SisFari"];
                                    arac.UretimYili = (DateTime)reader["UretimYili"];

                                    list.Add(arac);
                                }
                            }
                        }

                    }
                }
                return list;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
        public Arac AracEkle(Arac arac)
        {
            try
            {
               var query = new StringBuilder();
                query.Append("Insert into AracBilgileri ([AracTuru], [UretimYili], [Marka], [YakıtTuru], [MotorHacmi], [Km], [SatisFiyati], [AracResim], [SisFari], [KatlanılabilirAyna], [ParkSensoru], [MKS], [CamTavan], [OnayDurumu], [Model]) values (@AracTuru, @UretimYili, @Marka, @YakıtTuru, @MotorHacmi, @Km, @SatisFiyati, @AracResim, @SisFari, @KatlanılabilirAyna, @ParkSensoru, @MKS, @CamTavan, @OnayDurumu, @Model, )");
                //query.Append("Insert into UserTable ([Ad], [Soyad], [Email], [Password])");

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

                        DbHelper.AddParameter(cmd, "@AracTuru",arac.AracTuru,DbType.String,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@UretimYili", arac.UretimYili, DbType.DateTime, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Marka", arac.Marka, DbType.String, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@YakıtTuru",arac.YakıtTuru,DbType.String,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@MotorHacmi",arac.MotorHacmi,DbType.Int32,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Km",arac.Km, DbType.Int32, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@SatisFiyati",arac.SatisFiyati, DbType.Int32, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@AracResimleri",arac.AracResim, DbType.Byte,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@SisFari",arac.SisFari, DbType.Boolean,ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@KatlanılabilirAyna",arac.KatlanılabilirAyna, DbType.Boolean, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@ParkSensoru",arac.ParkSensoru, DbType.Boolean, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@MKS",arac.MKS, DbType.Boolean, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@CamTavan",arac.CamTavan, DbType.Boolean, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@OnayDurumu",arac.OnayDurumu, DbType.Boolean, ParameterDirection.Input);
                        DbHelper.AddParameter(cmd, "@Model",arac.Model, DbType.String,ParameterDirection.Input);

                        cmd.ExecuteNonQuery();

                    }
                }
                return arac;
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
