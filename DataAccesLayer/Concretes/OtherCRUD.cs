﻿using EntitiyLayer.Concretes;
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
    public class OtherCRUD
    {
        public string connectionString { get; set; }
        public bool loginStatus { get; set; }
        public OtherCRUD()
        {
            connectionString = DbHelper.getConnectionString();
            loginStatus = false;
        }
        public Arac AracEkle()
        {
            try
            {
                Arac arac = new Arac();

                var query = new StringBuilder();
                query.Append("Insert into AracBilgileri ([AracTuru], [UretimYili], [Marka], [YakıtTuru], [MotorHacmi], [Km], [SatisFiyati], [AracResimleri], [AracResimleri1], [AracResimleri2], [SisFari], [KatlanılabilirAyna], [ParkSensoru], [MKS], [CamTavan], [OnayDurumu], [Model]) values (@AracTuru, @UretimYili, @Marka, @YakıtTuru, @MotorHacmi, @Km, @SatisFiyati, @AracResimleri, @AracResimleri1, @AracResimleri2, @SisFari, @KatlanılabilirAyna, @ParkSensoru, @MKS, @CamTavan, @OnayDurumu, @Model, )");
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

                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);
                        DbHelper.AddParameter(cmd, "",);

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
    }
    
}
