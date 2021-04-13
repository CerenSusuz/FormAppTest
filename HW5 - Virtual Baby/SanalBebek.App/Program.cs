using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SanalBebek.App.Bebek;

namespace SanalBebek.App
{
    public class Bebek
    {
        private string ad; 
        public string Ad
        {
            get
            {
                return ad;
            }
            set
            {
                ad = value;
            }
        }
        public enum BebekRenkleri
        {
            Kırmızı = 1,
            Mavi = 2
        }
        private BebekRenkleri renk;
        public BebekRenkleri Renk
        {
            get
            {
                return renk;
            }
            set
            {
                renk = value;
                switch (renk)
                {
                    case BebekRenkleri.Kırmızı:
                        Console.BackgroundColor = ConsoleColor.Red;
                        break;
                    case BebekRenkleri.Mavi:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        break;
                    default:
                        Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ");
                        break;
                };
            }
        }
        public enum Cinsiyet
        {
            Kiz = 1,
            Erkek = 2
        }
        private Cinsiyet cins;
        public Cinsiyet Cins
        {
            get
            {
                return cins;
            }
            set
            {
                cins = value;
                switch (cins)
                {
                    case Cinsiyet.Kiz:
                        Console.WriteLine($"Merhaba sanal bebeğinizin adı {ad} ve cinsiyeti {cins} olarak kaydedildi.");
                        break;
                    case Cinsiyet.Erkek:
                        Console.WriteLine($"Merhaba sanal bebeğinizin adı {ad} ve cinsiyeti {cins} olarak kaydedildi.");
                        break;
                    default:
                        Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ");
                        break;
                };
            }
        }

        public enum BebekTurleri
        {
            Tavsan = 1,
            Kedi = 2,
            Fil = 3
        }
        private BebekTurleri tur;
        public BebekTurleri Tur
        {
            get
            {
                return tur;
            }
            set
            {
                tur = value;
                switch (tur)
                {
                    case BebekTurleri.Tavsan:
                        Console.WriteLine($"Hadi {tur} {ad}'in/ın Değerlerine bakalım");
                        break;
                    case BebekTurleri.Kedi:
                        Console.WriteLine($"Hadi {tur} {ad}'in/ın Değerlerine bakalım");
                        break;
                    case BebekTurleri.Fil:
                        Console.WriteLine($"Hadi {tur} {ad}'in/ın Değerlerine bakalım");
                        break;
                    default:
                        Console.WriteLine("YANLIŞ SEÇİM YAPTINIZ");
                        break;
                };
            }
        }
        private int saglik;
        public int Saglik
        {
            get
            {
                return saglik;
            }
            set
            {
                saglik = value;
                if (30 < saglik)
                {
                    Console.WriteLine($"Sağlık değeri = {saglik} Gayet İyi.");
                }
                else if (saglik < 30)
                {
                    if (2 < saglik || saglik < 20 ) //2-20 
                    {
                        Console.WriteLine($"Sağlık değeri = {saglik} Diğer değerleri yükseldikçe yükselecek.");
                    }
                    else
                    {
                        Console.WriteLine($"Sağlık değeri = {saglik} fena değil.");   
                    }
                }
                
            }
        }
        private int hijyen;
        public int Hijyen
        {
            get
            {
                return hijyen;
            }
            set
            {
                hijyen = value;
                if (30 < hijyen)
                {
                    Console.WriteLine($"Hijyen değeri = {hijyen} Gayet İyi.");
                }
                else if (hijyen < 30)
                {
                    if (2 < hijyen || hijyen < 20) //2-20 
                    {
                        Console.WriteLine($"Hijyen değeri = {hijyen} Banyo yaptır.");
                        BanyoYaptir(hijyen);
                    }
                    else
                    {
                        Console.WriteLine($"Hijyen değeri = {hijyen} fena değil.");
                    }
                }
            }
        }
        public static void BanyoYaptir(int hijyen)
        {
            Random rnd = new Random();
            hijyen += rnd.Next(5, 10);
            Console.Write($"Yeni Hijyen Seviyen-> {hijyen}");
        }
        private int uykusuzluk;
        public int Uykusuzluk
        {
            get
            {
                return uykusuzluk;
            }
            set
            {
                uykusuzluk = value;
                if (30 < uykusuzluk)
                {
                    Console.WriteLine($"Uykusuzluk değeri = {uykusuzluk} Gayet İyi.");
                }
                else if (uykusuzluk < 30)
                {
                    if (2 < uykusuzluk || uykusuzluk < 20) //2-20 
                    {
                        Console.WriteLine($"Uykusuzluk değeri = {uykusuzluk} Biraz uyusun.");
                        Uyut(uykusuzluk);
                    }
                    else
                    {
                        Console.WriteLine($"Uykusuzluk değeri = {uykusuzluk} fena değil.");
                    }
                }
            }
        }
        public static void Uyut(int uykusuzluk)
        {
            Random rnd = new Random();
            uykusuzluk -= rnd.Next(5, 10);
            Console.Write($"Yeni uykusuzluk seviyen {uykusuzluk}");
        }
        private int mutluluk;
        public int Mutluluk 
        {
            get
            {
                return mutluluk;
            }
            set
            {
                mutluluk = value;
                if (30 < mutluluk)
                {
                    Console.WriteLine($"Mutluluk Değeri = {mutluluk} Gayet İyi.");
                }
                else if (mutluluk < 30)
                {
                    if (2 < mutluluk || mutluluk < 20) //2-20 
                    {
                        Console.WriteLine($"Mutluluk değeri = {mutluluk} Diğer değerler arttıkça artacak.");
                    }
                    else
                    {
                        Console.WriteLine($"Mutluluk değeri = {mutluluk} fena değil.");
                    }
                }
            }
        }
        private int aclik;
        public int Aclik
        {
            get
            {
                return aclik;
            }
            set
            {
                aclik = value;
                if (30 < aclik)
                {
                    Console.WriteLine($"Açlık Değeri = {aclik} Gayet İyi.");
                }
                else if (aclik < 30)
                {
                    if (2 < aclik || aclik < 20) //2-20 
                    {
                        Console.WriteLine($"Açlık değeri = {aclik} Yemek yemeli.");
                        YemekYedir(aclik);
                    }
                    else
                    {
                        Console.WriteLine($"Açlık değeri = {aclik} fena değil.");
                    }
                }
            }
        }
        public static void YemekYedir(int aclik)
        {
            Random rnd = new Random();
            aclik -= rnd.Next(5, 10);
            Console.Write($"Yeni açlık seviyen {aclik}");
        }
        //public bool OlduMu { get; set; }
        
        public static void CizgiKoy()
        {
            Console.WriteLine("------------------");
        }
        public static void EkraniTemizle()
        {
            Console.Clear();
        }
        public static void DegerGoster()
        {
            Random rnd = new Random();
            char c = '\u25A0';
            string[] degerler = { "Sağlık", "Hijyen", "Uykusuzluk", "Mutluluk", "Açlık" };

            for (int i = 0; i < degerler.Length; i++)
            {
                Console.Write($"{degerler[i]}: ");
                int sayi = rnd.Next(2, 50);
                Console.Write(sayi);
                for (int j = 0; j < sayi; j++)
                {
                    Console.Write(c);
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Bebek sanalBebek = new Bebek(); //Bebek nesne örneği
            Console.Write("Bebeğinizin adı? :");
            string ad = Console.ReadLine();
            sanalBebek.Ad = ad; //ad get,sanalBebek.Ad set edildi
            //CİNSİYET
            EkraniTemizle();
            CizgiKoy();
            Console.Write("Bebeğinizin Cinsiyeti?[Kız-1 / Erkek-2] :");
            int cinsiyet = Convert.ToInt32(Console.ReadLine());
            int renk = cinsiyet;
            sanalBebek.Renk = (BebekRenkleri)renk;
            sanalBebek.Cins = (Cinsiyet)cinsiyet;
            //TÜR
            EkraniTemizle();
            CizgiKoy();
            Console.WriteLine($"{(Cinsiyet)cinsiyet} sanal bebeğiniz {ad} 'in/ın türü ne olsun istersiniz?\n 1-Tavşan\n 2-Kedi\n 3-Fil");
            int tur = Convert.ToInt32(Console.ReadLine());
            sanalBebek.Tur = (BebekTurleri)tur;
            CizgiKoy();
            Random rnd = new Random();
            int saglik = rnd.Next(2, 50);
            int hijyen = rnd.Next(2, 50);
            int uykusuzluk = rnd.Next(2, 50);
            int mutluluk = rnd.Next(2, 50);
            int aclik = rnd.Next(2, 50);
            DegerGoster();
            CizgiKoy();
            sanalBebek.Saglik = saglik;
            sanalBebek.Hijyen = hijyen;
            sanalBebek.Uykusuzluk = uykusuzluk;
            sanalBebek.Mutluluk = mutluluk;
            sanalBebek.Aclik = aclik;

            Console.ReadKey();
        }
    }
}
