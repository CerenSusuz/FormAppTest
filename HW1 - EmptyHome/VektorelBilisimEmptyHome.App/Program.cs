using System;
namespace VektorelBilisimEmptyHome.App
{
    class Program
    {
        static void Main(string[] args)
        {
            //Karakter elleri kelepçeli bomboş bir odada uyanıyor.Önünde üzerinde farklı şeyler yazan 3 kapı var,seçim yapması gerek.
            int can_sayisi = 1; //Oyun başlangıcında seçim yapma hakkı '1'.Yanlış seçimlerde can sayısı sıfırlanır ve oyun biter,doğru seçimlerde artar-artmasının bir faydası yok ama artıyor-.
            Console.Write("Günaydın uykucu bana adını söyler misin ? -kullanıcı adınızı giriniz- :");
            string kullanici_adi = Console.ReadLine().ToUpper();
            Console.WriteLine($"Evime Hoşgeldin {kullanici_adi}\n------Kelepçeden kurtulmak için önce birkaç 'doğru' seçim yapmalısın.------\n------                     Hadi Başlayalım                           ------");
            Console.WriteLine("\nÖnünde 3 kapı var ve bunlardan biri oyuna devam etmeni sağlıyor.");
            Console.WriteLine("1-Güzel Bir Kahvaltı\n2-Para Dolu Çanta \n3-Oyunun 2.Bölümü ");
            char secim = Console.ReadKey(true).KeyChar;
            if (secim == '1')
            {
                can_sayisi--; //can sayısı sıfırlandı ve canı bitti.
                Console.WriteLine("HADİ AMA BU YANLIŞ KAPI! EMEK OLMADAN YEMEK OLMAZ !!!");
                Console.Write($"Kalan canın = {can_sayisi}");
                Console.Write("\nŞu işlemin sonucunu girip oyunu bitiriniz->(9*9)");
                string cevap = Console.ReadLine();
                if (cevap == "81")
                {
                    Console.WriteLine("\nDoğru Cevap,OYUN BİTTİ, YİNE BEKLERİZ!");
                }
                else
                {
                    Console.WriteLine("\n Matematik çalışmayı unutmayın. Oyun Bitti.");
                }
            }
            else if (secim == '2')
            {
                can_sayisi--; //can sayısı sıfırlandı ve canı bitti.
                Console.WriteLine("SENİ PARAGÖZ SENİ! VARSA PARAN VER BANA,KURTUL!!!");
                Console.Write($"Kalan canın = {can_sayisi}");
                Console.Write("\nŞu işlemin sonucunu girip oyunu bitiriniz->(9*8)");
                string cevap = Console.ReadLine();
                if (cevap == "72")
                {
                    Console.WriteLine("\nDoğru Cevap, OYUN BİTTİ, YİNE BEKLERİZ!");
                }
                else
                {
                    Console.WriteLine("\n Matematik çalışmayı unutmayın. Oyun Bitti.");
                }
            }
            else if (secim == '3')
            {
                Console.WriteLine(" Kapı gibi yazıyor 'Oyunun 2.Bölümü' diye. DOĞRU SEÇİM TEBRİKLER");
                can_sayisi++; //can sayısı arttı ve 2 oldu.
                Console.WriteLine($"  Can sayın 1 arttı ve çikolata kazandın.\n   Toplam Can= {can_sayisi}");
                Console.WriteLine("    Enerjini topladığına göre sıradaki seçimimiz-> (UNUTMA yanlış seçimde canın sıfırlanır ve oyun biter.) ");
                Console.Write("1-Su\n2-Seri Katil\n3-Eski Sevgilin");
                char secim2 = Console.ReadKey(true).KeyChar;
                if (secim2 == '1')
                {
                    can_sayisi += 2; //can sayısı arttı ve 4 oldu.
                    Console.WriteLine($"\n Doğru Kapı :):) Çikolata susatmıştır al,iç.\n  Toplam Can = {can_sayisi}");
                    Console.WriteLine("   Sıradaki seçime geç.-> Bu SON Oyunumuz, yanlış seçimde canın sıfırlanır ve kaybedersin.");
                    Console.Write("1-Çıkış Kapısı\n2-BEN :)\n3-Netflix Üyeliği");
                    char son_secim = Console.ReadKey(true).KeyChar;
                    if (son_secim == '1')
                    {
                        Console.WriteLine("\nNONONO. Öyle hemen gitmek olur mu? Daha karpuz kesicektik...");
                        can_sayisi -= 4;
                        Console.WriteLine($"Toplam Can: {can_sayisi}");
                        Console.WriteLine("KAYBETTİNİZ, YİNE BEKLERİZ!");
                    }
                    else if (son_secim == '2')
                    {
                        can_sayisi += 3; //can sayısı 7 oldu.
                        Console.WriteLine($"\nBEN tabii ki doğru seçimim :) Toplam Can = {can_sayisi} İşte ödülün ->");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("                 Kelepçenin Anahtarı");
                        Console.WriteLine("-------------------------------------------------------------");
                        Console.WriteLine("TEBRİKLER.");
                    }
                    else if (son_secim == '3')
                    {
                        Console.WriteLine("\nBizden Netflix üyeliği kazandınız ama bu odada çürümeye mahkumsunuz.");
                        can_sayisi -= 4;
                        Console.WriteLine($"Toplam Can: {can_sayisi} .");
                        Console.WriteLine("KAYBETTİNİZ, YİNE BEKLERİZ!");
                    }
                    else
                    {
                        Console.WriteLine("\nYanlış Karakter. Çık Oyundan Çık.!");
                    }
                }

                else if (secim2 == '2')//seri katil
                {
                    can_sayisi -= 2;
                    Console.WriteLine($"\nYanlış seçim ama sonuç aynı 'ölüm'.Kalan canın = {can_sayisi}");
                    Console.WriteLine("Kaybettiniz.");
                    Console.Write("\nŞu işlemin sonucunu girip oyunu bitiriniz->(55/5)");
                    string cevap = Console.ReadLine();
                    if (cevap == "11")
                    {
                        Console.WriteLine("\n OYUN BİTTİ, YİNE BEKLERİZ!");
                    }
                    else
                    {
                        Console.WriteLine("\n Matematik çalışmayı unutmayın. Oyun Bitti.");
                    }
                }
                else if (secim2 == '3') //eski sevgili
                {
                    can_sayisi -= 2;
                    Console.WriteLine($"\nYanlış seçim üzgünüm.Eskileri aşman lazım.\nToplam canın = {can_sayisi}");
                    Console.WriteLine("Kaybettiniz.");
                    Console.Write("Şu işlemin sonucunu girip oyunu bitiriniz->(1000/100)");
                    string cevap = Console.ReadLine();
                    if (cevap == "10")
                    {
                        Console.WriteLine("\n OYUN BİTTİ, YİNE BEKLERİZ!");
                    }
                    else
                    {
                        Console.WriteLine("\n Matematik çalışmayı unutmayın. Oyun Bitti.");
                    }
                }
                else //yanlış karakter
                {
                    Console.WriteLine("\nYanlış Karakter. Çık Oyundan Çık.!!");
                }
            }
            else
            {
                Console.WriteLine("3 seçeneğin var zaten neden yanlış giriyorsun :( Yok sana oyun HOŞÇAKAL! ");
            }
            Console.ReadKey();
        }
    }
    }
