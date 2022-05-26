using DataAccesLayer.Concretes;
using EntitiyLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModelLayer.Concretes
{
    public class OtherVM
    {
        public Arac AracEkle(Arac arac)
        {
            try
            {
                using (var repo = new OtherCRUD())
                {
                    repo.AracEkle(arac);
                }
                return arac;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Arac> ListArac()
        {
            try
            {
                List<Arac> aracs = new List<Arac>();
                using (var repo = new OtherCRUD())
                {
                    aracs =repo.AracList();
                }
                return aracs;
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
