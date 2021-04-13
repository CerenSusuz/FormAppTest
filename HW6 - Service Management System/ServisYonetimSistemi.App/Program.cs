using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServisYonetimSistemi.App
{
    class Program
    {
       static void Main(string[] args)
        {
            string[] adlar = new string[0];
            Servis[] servisler = new Servis[0];
            while (true)
            {
              Console.Write("----------Servis Yönetim Sistemi----------\n          1-Servis Ekle\n          2-Öğrenci Kaydet\n          3-Bilgileri Görüntüle\n          4-ÇIKIŞ\n------------------------------------------");
              char karar = Console.ReadKey(true).KeyChar;
            
              if (karar == '1') //Servis Ekle
              {
                Console.Clear();
                Servis servis = new Servis();
                Console.WriteLine("\n  Servis Ekle seçeneğini seçtiniz->");
                Console.Write("  Servis Ad:");
                servis.Adlar = new List<string>();
                string ad = Console.ReadLine();
                Array.Resize(ref adlar, adlar.Length + 1);
                adlar[adlar.Length - 1] = ad;
                Console.Write("  Servis Plakası:");
                servis.Plaka = Console.ReadLine();
                Console.Write("  Servis Markası:");
                servis.Marka = Console.ReadLine();
                Sofor sofor = new Sofor();
                servis.Sofor = sofor;
                Console.Write("  Şoför Ad:");
                sofor.Ad = Console.ReadLine();
                Console.Write("  Şoför Soyad:");
                sofor.Soyad = Console.ReadLine();
                Console.Write("  Kaç yıldır sürücülük yapıyor:");
                sofor.Sure = Console.ReadLine();
                Array.Resize(ref servisler, servisler.Length + 1);
                servisler[servisler.Length - 1] = servis;
                servis.Ogrenciler = new List<Ogrenci>();
                Console.WriteLine("Servis Eklendi.");
              }
                else if ( karar == '2')
                {
                    Console.Clear();
                    if (servisler.Length>0) //kayıtlı servis var
                    {
                        Console.WriteLine("\n  Öğrenci Kaydet seçeneğini seçtiniz->");
                        for (int i = 0; i < servisler.Length;)  //servis bilgileri
                        {
                            foreach (Servis srv in servisler)
                            { 
                                Console.Write($" \n{adlar[i]} adlı servis ->");
                                Console.WriteLine(srv.ServisBilgileriniGetir());
                                i++;
                            }
                        }
                        Console.Write("\n Hangi Servise Kayıt Edilecek:");
                        string secim = Console.ReadLine().ToLower();
                        if (!adlar.Contains(secim)) //servis adı yanlış girildi
                        {
                            Console.WriteLine("Yanlış Giriş.");
                        }
                        else //servis adı doğru
                        {
                            Ogrenci ogr = new Ogrenci();
                            Console.Write("  Öğrenci Ad:");
                            ogr.Ad = Console.ReadLine();
                            Console.Write("  Öğrenci Soyad:");
                            ogr.Soyad = Console.ReadLine();
                            Console.Write("  Öğrenci No:");
                            ogr.No = Console.ReadLine();
                            Console.Write("  Öğrenci Sınıf:");
                            ogr.Sinif = Console.ReadLine();
                            for (int i = 0; i < servisler.Length; i++)
                            {
                                if (adlar[i] == secim) //girilen adla servislerin elemanları eşleştiğinde
                                {
                                    servisler[i].Ogrenciler.Add(ogr);
                                    Console.WriteLine($"  {secim} adlı servise kayıt edildiniz.\n");
                                }
                            }
                        }
                    }
                    else //kayıtlı servis yok
                    {
                        Console.WriteLine("\n-----Menüye dönüp Servis Ekleyiniz.-----\n");
                    }
                    
                }
                else if (karar == '3')
                {
                    Console.Clear();
                    if (servisler.Length > 0) //ekrana servis bilgileri verildi
                    {
                        Console.WriteLine("\n-----------------");
                        Console.WriteLine("Servis Bilgileri");
                        Console.WriteLine("\n-----------------");
                        for (int i = 0; i < adlar.Length;)
                        {
                            foreach (Servis srv in servisler)
                            {
                                Console.Write($" {adlar[i]} adlı servis ->"); 
                                Console.WriteLine(srv.ServisBilgileriniGetir());
                                i++;
                             }
                        }
                            Console.Write("\n Hangi servisin öğrenci bilgilerini istiyorsunuz?");
                            string secim = Console.ReadLine().ToLower();
                        if (!adlar.Contains(secim))
                        {
                            Console.WriteLine("Yanlış Giriş");
                        }
                        else
                        {
                            for (int i = 0; i < adlar.Length; i++)
                            {
                                if (adlar[i] == secim) //aranan servis bulunduğunda
                                {
                                    foreach (var ogr in servisler[i].Ogrenciler)
                                    {
                                        Console.WriteLine($"{ogr.Ad} {ogr.Soyad} Numarası:{ogr.No}");
                                    }
                                }
                            }
                        }
                      

                    }
                    else
                    {
                        Console.WriteLine("\n-----Kayıtlı servis yok-----\n-----Menüye dönüp Servis Ekleyiniz.-----\n");
                    }
                }
                else if ( karar == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nGeçerli seçim yap");
                }
            }
        }
    }
}
