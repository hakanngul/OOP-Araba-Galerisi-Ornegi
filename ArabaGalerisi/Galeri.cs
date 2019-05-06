using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGalerisi
{
    class Galeri
    {
        private List<Araba> Arabalar = new List<Araba>();
        public void ArabaEkle(Araba A)
        {
            Arabalar.Add(A);
        }
        public void ArabaSat(Araba A)
        {
            Arabalar.Remove(A);
        }
        public string ArabaListele()
        {
            string temp = "";
            foreach (Araba a in Arabalar)
            {
                temp += "Marka: " + a.Marka + "\tModel: " + a.Model + "\tRenk: " + a.Renk + Environment.NewLine;
            }
            return temp;
        }
    }
}
