using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concretes
{
    public class Arac
    {
        public int AracId { get; set; }
        public string AracTuru { get; set; }
        public DateTime UretimYili { get; set; }
        public string Marka { get; set; }

        public string Model { get; set; }
        public string YakıtTuru { get; set; }
        public int MotorHacmi { get; set; }
        public int Km { get; set; }

        public int SatisFiyati { get; set; }
        public byte[] AracResim { get; set; }
        public byte[] AracResim1 { get; set; }
        public byte[] AracResim2 { get; set; }
        public bool SisFari { get; set; }
        public bool KatlanılabilirAyna { get; set; }
        public bool ParkSensoru { get; set; }
        public bool MKS { get; set; }
        public bool CamTavan { get; set; }
        public bool OnayDurumu { get; set; }
    }
}
