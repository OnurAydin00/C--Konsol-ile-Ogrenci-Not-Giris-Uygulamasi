using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Ogrenci_Not_Giris_Ekranı
{
    internal class Program
    {
        public enum Islem { Notlar = 0, Ders1 = 1, Ders2 = 2, Ders3 = 3, Ders4 = 4, Ders5 = 5, Ders6 = 6, Ders7 = 7, Ders8 = 8, Geri = 9, Çıkış = 10, }
        static void Main(string[] args)
        {
            string ders1 = "Tıbbi Cihazlar II";
            string ders2 = "Hastane Otomasyonu II";
            string ders3 = "Yazılım Kurulumu ve Yönetimi";
            string ders4 = "Sunucu İşletim Sistemi";
            string ders5 = "Mesleki Yabancı Dil II";
            string ders6 = "Bilişim Güvenliği";
            string ders7 = "Sistem Analizi ve Tasarımı";
            string ders8 = "Açık Kaynak İşletim Sistemi";

            string cizgi = new string('-', 30);
            bool kullaniciIslemi = true;

            ArrayList ogrenciNumarasi = new ArrayList();
            double[] notlar = new double[8];


            Console.Write("Not girişi yapılacak öğrencinin öğrenci numarasını giriniz: ");
            int ogrenci = Convert.ToInt32(Console.ReadLine());

            ogrenciNumarasi.Add(ogrenci);

            do
            {
                Console.WriteLine(cizgi + "Dersler" + cizgi);
                Console.Write("0-Öğrencinin Notlarını Görüntüleyin.\n1-Tıbbi Cihazlar II\n2-Hastane Otomasyonu II\n3-Yazılım Kurulumu ve Yönetimi\n4-Sunucu İşletim Sistemi\n5-Mesleki Yabancı Dil II\n6-Bilişim Güvenliği\n7-Sistem Analizi ve Tasarımı\n8-Açık Kaynak İşletim Sistemi\n9-Geri\n10-Çıkış\n\n" + new string('-', 5) + "İşlem Seçiniz: ");
                int islemSecim = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine();

                switch (islemSecim)
                {
                    case (int)Islem.Notlar:
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin Ders Notları\n", ogrenci);

                        Console.WriteLine(new string(' ', 5) + "Ders Adı" + new string(' ', 25) + "Sınav Notları");
                        Console.WriteLine();
                        if (notlar[0] == 0) // eğer tıbbi cihazlar dersinin notu girilmediği için sıfır olacak ve buna bağlı olarak da dersin notu girilmedi olarak yazacak.
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "Girilmedi", ders1);
                        }
                        else
                        {
                            if (notlar[0] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "{1} Geçti", ders1, notlar[0]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "{1} Kaldı", ders1, notlar[0]);
                            }
                        }

                        if (notlar[1] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 7) + "Girilmedi", ders2);
                        }
                        else
                        {
                            if (notlar[1] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 7) + "{1} Geçti", ders2, notlar[1]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 7) + "{1} Kaldı", ders2, notlar[0]);
                            }
                        }

                        if (notlar[2] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: Girilmedi", ders3);
                        }
                        else
                        {
                            if (notlar[2] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: {1} Geçti", ders3, notlar[2]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: {1} Kaldı", ders3, notlar[2]);
                            }
                        }

                        if (notlar[3] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "Girilmedi", ders4);
                        }
                        else
                        {
                            if (notlar[3] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "{1} Geçti", ders4, notlar[3]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "{1} Kaldı", ders4, notlar[3]);
                            }
                        }

                        if (notlar[4] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "Girilmedi", ders5);
                        }
                        else
                        {
                            if (notlar[4] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "{1} Geçti", ders5, notlar[4]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 6) + "{1} Kaldı", ders5, notlar[4]);
                            }
                        }

                        if (notlar[5] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "Girilmedi", ders6);
                        }
                        else
                        {
                            if (notlar[5] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "{1} Geçti", ders6, notlar[5]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 11) + "{1} Kaldı", ders6, notlar[5]);
                            }
                        }

                        if (notlar[6] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 2) + "Girilmedi", ders7);
                        }
                        else
                        {
                            if (notlar[6] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 2) + "{1} Geçti", ders7, notlar[6]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 2) + "{1} Kaldı", ders7, notlar[6]);
                            }
                        }

                        if (notlar[7] == 0)
                        {
                            Console.WriteLine("{0} Ders Notu: " + new string(' ', 1) + "Girilmedi", ders8);
                        }
                        else
                        {
                            if (notlar[7] >= 50)
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 1) + "{1} Geçti", ders8, notlar[7]);
                            }
                            else
                            {
                                Console.WriteLine("{0} Ders Notu: " + new string(' ', 1) + "{1} Kaldı", ders8, notlar[7]);
                            }
                        }
                        Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        Console.ReadKey();
                        break;

                    case (int)Islem.Ders1: // DERS 1' in KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders1);

                        Console.Write("Vize Notu: ");
                        double tıbbiVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double tıbbiFinalNot = Convert.ToDouble(Console.ReadLine());

                        double tıbbiOrtama = tıbbiVizeNot * .4 + tıbbiFinalNot * .6;
                        notlar[0] = tıbbiOrtama;

                        if (notlar[0] > 50 || tıbbiFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders1, tıbbiOrtama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders1, tıbbiOrtama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders2: // DERS 2' in KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders2);

                        Console.Write("Vize Notu: ");
                        double hastaneVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double hastaneFinalNot = Convert.ToDouble(Console.ReadLine());

                        double hastaneOrtalama = hastaneVizeNot * .4 + hastaneFinalNot * .6;
                        notlar[1] = hastaneOrtalama;

                        if (hastaneOrtalama > 50 && hastaneFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders2, hastaneOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders2, hastaneOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders3: // DERS 3' ün KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders3);

                        Console.Write("Vize Notu: ");
                        double yazilimVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double yazilimFinalNot = Convert.ToDouble(Console.ReadLine());

                        double yazilimOrtalama = yazilimVizeNot * .4 + yazilimFinalNot * .6;
                        notlar[2] = yazilimOrtalama;

                        if (yazilimOrtalama > 50 && yazilimFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders3, yazilimOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders3, yazilimOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders4: // DERS 4' ün KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders4);

                        Console.Write("Vize Notu: ");
                        double sunucuVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double sunucuFinalNot = Convert.ToDouble(Console.ReadLine());

                        double sunucuOrtalama = sunucuVizeNot * .4 + sunucuFinalNot * .6;
                        notlar[3] = sunucuOrtalama;

                        if (sunucuOrtalama > 50 && sunucuFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders4, sunucuOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders4, sunucuOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders5: // DERS 5' in KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders5);

                        Console.Write("Vize Notu: ");
                        double ingilizceVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double ingilizceFinalNot = Convert.ToDouble(Console.ReadLine());

                        double ingilizceOrtalama = ingilizceVizeNot * .4 + ingilizceFinalNot * .6;
                        notlar[4] = ingilizceOrtalama;

                        if (ingilizceOrtalama > 50 && ingilizceFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders5, ingilizceOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders5, ingilizceOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders6: // DERS 6' nın KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders6);

                        Console.Write("Vize Notu: ");
                        double bilisimVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double bilisimFinalNot = Convert.ToDouble(Console.ReadLine());

                        double bilisimOrtalama = bilisimVizeNot * .4 + bilisimFinalNot * .6;
                        notlar[5] = bilisimOrtalama;

                        if (bilisimOrtalama > 50 && bilisimFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders6, bilisimOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders6, bilisimOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders7: // DERS 7' nin KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders7);

                        Console.Write("Vize Notu: ");
                        double sistemAnaliziVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double sistemAnaliziFinalNot = Convert.ToDouble(Console.ReadLine());

                        double sistemAnaliziOrtalama = sistemAnaliziVizeNot * .4 + sistemAnaliziFinalNot * .6;
                        notlar[6] = sistemAnaliziOrtalama;

                        if (sistemAnaliziOrtalama > 50 && sistemAnaliziFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders7, sistemAnaliziOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {0}", ders7, sistemAnaliziOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Ders8: // DERS 8' in KODLARI
                        Console.Clear();
                        Console.WriteLine("{0} Numaralı Öğrencinin {1} Ders Notlarını Giriniz.", ogrenci, ders8);

                        Console.Write("Vize Notu: ");
                        double acikKaynakVizeNot = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Final Notu: ");
                        double acikKaynakFinalNot = Convert.ToDouble(Console.ReadLine());

                        double acikKaynakOrtalama = acikKaynakVizeNot * .4 + acikKaynakFinalNot * .6;
                        notlar[7] = acikKaynakOrtalama;

                        if (acikKaynakOrtalama > 50 && acikKaynakFinalNot >= 50)
                        {
                            Console.WriteLine("{0} dersinden geçtiniz. Ortalamanız: {1}", ders8, acikKaynakOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }
                        else
                        {
                            Console.WriteLine("{0} dersinden kaldınız. Ortalamanız: {1}", ders8, acikKaynakOrtalama);
                            Console.Write("\nAna menüye dönmek için herhangi bir tuşa basınız.");
                        }

                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case (int)Islem.Çıkış: // ----------ÇIKIŞ İŞLEMLERİ 
                        kullaniciIslemi = false;
                        Console.WriteLine("Sistemden çıkış yapıldı.");
                        break;

                    case (int)Islem.Geri: // ----------BURAYA TEKRAR BAKILACAK 
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Yukarıdaki İşlemleri Seçtiğinizden Emin Olunuz. Tekrar Denemek İçin Herhangi Bir Tuşa Basınız.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear(); // GEÇERSİZ İŞLEM HATASINDAN SONRA KOD FAZLALIĞINI TEMİZLEYECEK.

            } while (kullaniciIslemi);
            Console.WriteLine("Çıkış İşlemi Başarılı!");
            Console.ReadKey();
        }
    }
}
