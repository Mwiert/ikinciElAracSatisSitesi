using EntitiyLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModelLayer.Concretes;

namespace ServiceLayer.Concretes.dotnet
{
    public class OtherService
    {
        OtherVM otherVM = new OtherVM();
        public void AracEkle(Arac arac)
        {
            try
            {
                otherVM.AracEkle(arac);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
