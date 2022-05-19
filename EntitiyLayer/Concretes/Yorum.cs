using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Concretes
{
    public class Yorum
    {
        public int Yorumid { get; set; }
        public User UserId { get; set; }
        public Arac Aracid { get; set; }
        public string Yorumİcerigi { get; set; }
        public Yorum()
        {
            UserId = new User();
            Aracid = new Arac();
        }
    }
}
