using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisYonetimSistemi.App
{
    public class Servis
    {
        public List<string> Adlar { get; set; }
       
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public Sofor Sofor { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }
       
        public string ServisBilgileriniGetir()
        {
           return $"\n Plaka:{Plaka}\n Marka:{Marka}\n Şoför Ad:{Sofor.Ad} Soyad:{Sofor.Soyad} Şoförlük Süresi:{Sofor.Sure}";
        }

    }
}
