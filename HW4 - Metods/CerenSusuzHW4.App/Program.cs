using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CerenSusuzHW4.App
{
    class Program
    {
        static void Main(string[] args)
        {
            CizgiKoy();
            string giris = "MATEMATİKSEL İŞLEMLER";
            GirisiYazdir(giris);
            CizgiKoy();
            Bekle();
            EkraniTemizle();
            string ad = KullaniciAdiAl();
            SelamVer(ad);
            string cevap = CevabiniAl();

            if (cevap == "evet")
            {
                Bekle();
                EkraniTemizle();
                İlkSoruYap();
                Bekle();
                EkraniTemizle();
                İkinciSoruYap();
                Bekle();
                EkraniTemizle();
                char secim = UcuncuSoruYap(); //1 ya da 2 döndü
                if (secim == '1')
                {
                    Bekle();
                    EkraniTemizle();
                    DorduncuSoruYap();  //1 ya da 2 döndü
                    char secim4 = SecimYap2();
                    if (secim4 == '1')
                    {
                        Console.WriteLine("Güzel Oyundu.");
                    }
                    else if (secim4 == '2')
                    {
                        Console.WriteLine("Yine Bekleriz");
                    }
                    else
                    {
                        for (int i = 0; i < 1;)
                        {
                            break;
                        }
                    }

                }
                else if (secim == '2')
                {
                    Bekle();
                    EkraniTemizle();
                    BesinciSoruYap();
                    char secim5 = SecimYap3();
                    if (secim5 == '1')
                    {
                        Console.WriteLine("Güzel Oyundu.");
                    }
                    else if (secim5 == '2')
                    {
                        Console.WriteLine("Yine Bekleriz");
                    }
                    else
                    {
                        for (int i = 0; i < 1;)
                        {
                            break;
                        }
                    }
                }

            }
            else if (cevap == "hayır")
            {
                KapanisMesajiVer();
                for (int i = 0; i < 1;)
                {
                    break;
                }
            }

            Console.ReadKey();
        }
        public static void EkraniTemizle() //void,noparameters1
        {
            Console.Clear();
        }
        public static void CizgiKoy()  //void,noparameters2
        {
            Console.WriteLine("---------------------");
        }
        public static void Bekle() //void,noparameters3
        {
            Thread.Sleep(450);
        }
        public static void GirisiYazdir(string giris) //void,yesparameters1
        {
            Console.WriteLine(giris);
        }
        public static string KullaniciAdiAl() //return,noparm1
        {
            Console.Write("Kullanıcı Adınız:");
            string kullanici_adi = Console.ReadLine();
            return kullanici_adi;
        }
        public static void SelamVer(string ad) //void,yesparm2
        {
            Console.WriteLine($"Merhaba {ad}...\n İşlem yapmaya hazır mısın?[Evet,Hayır]");
        }
        public static string CevabiniAl()  //return,noparm2
        {
            string cevap = Console.ReadLine().ToLower();
            return cevap;
        }
        public static void İlkSoruYap() //void,noparm4
        {
            int puan = 50;
            Console.WriteLine("İlk Soru -> [10*10]");
            int sonuc = Convert.ToInt32(Console.ReadLine());
            if (sonuc == 100)
            {
                puan += 50;
                Console.WriteLine("Doğru Cevap");
                Console.WriteLine($"Toplam Puan->{puan}");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap");
                puan -= 50;
                Console.WriteLine($"Toplam Puan->{puan}");
            }
        }
        public static void İkinciSoruYap() //void,noparm5
        {
            Console.Write("Sıradaki İşlemi Yap -> [(5!*5!)]"); //((5 * 4 * 3 * 2 * 1) * (5 * 4 * 3 * 2 * 1)) = 14400
            int puan = 50;
            int cevap = Convert.ToInt32(Console.ReadLine());
            if (cevap == 14400)
            {
                puan += 50;
                Console.WriteLine("Doğru Cevap");
                Console.WriteLine($"Toplam Puan->{puan}");
            }
            else
            {
                Console.WriteLine("Yanlış Cevap");
                puan -= 50;
                Console.WriteLine($"Toplam Puan->{puan}");
            }
        }
        public static char UcuncuSoruYap()
        {
            Console.WriteLine("Sırada bir seçim yapma sorusu var ->İkisinden birini seçmek zorundasın.");
            Console.Write("Ömür boyu\n 1-Kuru köpek maması yemek mi?\n 2-Islak kedi maması yemek mi?");
            char secim = Console.ReadKey(true).KeyChar;
            if (secim == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Kopek maması en azından kuru...");
            }
            else if (secim == '2')
            {
                Console.WriteLine();
                Console.WriteLine("ISLAK ISLAK KOKULU KEDİ MAMASI NO.");
            }
            else
            {
                for (int i = 0; i < 1;)
                {
                    break;
                }
            }
            return secim;
        }

        public static void DorduncuSoruYap()
        {
            Console.WriteLine("Sırada bir seçim yapma sorusu daha var -> İkisinden birini seçmek zorundasın.");
            Console.Write("Ömür boyu\n 1-Bedava akaryakıt almak mı?\n 2-Bedava en sevdiğin yemeği yemek mi?");
            SecimYap2();
        }
        public static char SecimYap2()
        {
            char secim = Console.ReadKey(true).KeyChar;
            if (secim == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Benim arabam yok :(");
                KapanisMesajiVer();

            }
            else if (secim == '2')
            {
                Console.WriteLine();
                Console.WriteLine("Ohhh be bu seçilmez mi??!?");
                KapanisMesajiVer();
            }
            else
            {
                for (int i = 0; i < 1;)
                {
                    break;
                }
            }
            return secim;
        }
        public static void BesinciSoruYap()
        {
            Console.WriteLine("Sırada bir seçim yapma sorusu daha var -> İkisinden birini seçmek zorundasın.");
            Console.Write("Hangi süper güce sahip olmak isterdiniz=\n 1-Uçmak?\n 2-Zihin Okumak?");
            SecimYap3();

        }
        public static char SecimYap3()
        {
            char secim = Console.ReadKey(true).KeyChar;
            if (secim == '1')
            {
                Console.WriteLine();
                Console.WriteLine("Yükseklik korkum var :(");
                KapanisMesajiVer();
            }
            else if (secim == '2')
            {
                Console.WriteLine();
                Console.WriteLine("Herkesin düşüncelerini okumak iyi olabilir.");
                KapanisMesajiVer();
            }
            else
            {
                for (int i = 0; i < 1;)
                {
                    break;
                }
            }
            return secim;
        }
        public static void KapanisMesajiVer()
        {
            Console.WriteLine("Yine Gel...");
        }
    }
}
