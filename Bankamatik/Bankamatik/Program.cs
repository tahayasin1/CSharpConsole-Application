using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankamatik_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            float bakiye = 250;
            float kart_borcu = 1000;
            string dogru_kart_numarasi = "123456789012";
            string dogru_sifre = "ab18";
            int giris_hakki = 3;
            int kredi_k_giris_hakki = 3;
            string hesaptan_kes_kabul_mu = "1";
            float ne_kadar_kesilsin = 0;
            string dogru_ulke_kodu = "TR";
            string dogru_eft_no = "987654321012";
            string dogru_hesap_no = "14725836901";
            string yeni_tutar = "2";
            string dogru_elktrik_no = "123";
            string dogru_telefon_no = "5555555";
            string dogru_internet_abone_no = "456";
            string dogru_su_faturasi_no = "789";
            int elektrik_borc = 250;
            int telefon_borc = 120;
            int internet_borc = 100;
            int su_faturasi_borc = 80;
            int ogs_tutar = 0;
            int a = 0;
            int b = 0;

            string islem;
            Console.Write("1-Kartlı işlem için, 2-Kartsız işlem için Q-Çıkış için\n\tYapılacak İşlem: ");
            islem = Console.ReadLine();

            while (true)
            {
                if (islem != "1")
                {
                    a += 1;
                }
                if (islem != "2")
                {
                    a += 1;
                }
                if (islem != "Q")
                {
                    a += 1;
                }
                if (islem != "q")
                {
                    a += 1;
                }
                if (a == 4)
                {
                    Console.WriteLine("Yanlış kodlama hatası");
                }
                break;
            }

            while (islem == "1") 
            {
                if (a == 8)
                {
                    break;
                }
                string girilen_sifre;
                Console.Write("Şifre: ");
                girilen_sifre = Console.ReadLine();
                if (girilen_sifre == dogru_sifre)
                {
                    Console.WriteLine("Giriş başarılı\n\n");
                    break;
                }
                if (girilen_sifre != dogru_sifre)
                {
                    giris_hakki--;
                    Console.WriteLine("Girilen şifre hatalı\n");
                    if (giris_hakki == 0)
                    {
                        Console.WriteLine("\tGiriş hakkınız doldu hesabınız bloke edildi");
                        break;
                    }
                }
            }
            while (true)
            {
                if (giris_hakki == 0)
                {
                    break;
                }
                if (hesaptan_kes_kabul_mu == "Q" || hesaptan_kes_kabul_mu == "q")
                {
                    Console.WriteLine("Yine bekleriz :)");
                    break;
                }
                if (a == 4 || b == 8)
                {
                    break;
                }
                string kartli_islem;
                Console.Write("Para Çekmek için-1, Para yatırmak için-2, Para Transferleri-3, Eğitim Ödemeleri-4, Ödemeler-5, Bilgi Güncelleme-6 Q-Çıkış için\n\tYapılacak İşlem: ");
                kartli_islem = Console.ReadLine();
                if (islem == "1")
                {
                    while (true)
                    {
                        if (kartli_islem != "1")
                        {
                            b++;
                        }
                        if (kartli_islem != "2")
                        {
                            b++;
                        }
                        if (kartli_islem != "3")
                        {
                            b++;
                        }
                        if (kartli_islem != "4")
                        {
                            b++;
                        }
                        if (kartli_islem != "5")
                        {
                            b++;
                        }
                        if (kartli_islem != "6")
                        {
                            b++;
                        }
                        if (kartli_islem != "Q")
                        {
                            b++;
                        }
                        if (kartli_islem != "q")
                        {
                            b++;
                        }
                        if (b == 8)
                        {
                            Console.WriteLine("Yanlış kodlama hatası");
                        }
                        break;
                    }
                    if (kartli_islem == "1")
                    {
                        float cekilecek_tutar;
                        Console.Write("Çekilecek tutar: ");
                        cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                        if (cekilecek_tutar <= bakiye)
                        {
                            bakiye = bakiye - cekilecek_tutar;
                            Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                            string devam_mi;
                            Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                            devam_mi = Console.ReadLine();
                            if (devam_mi == "1")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz :)");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Hesabınızda " + cekilecek_tutar + " TL paranız yok\n\tHesabınızdaki bakiye: " + bakiye);
                            string devam_mi;
                            Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                            devam_mi = Console.ReadLine();
                            if (devam_mi == "1")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz :)");
                                break;
                            }
                        }
                    }
                    if (kartli_islem == "2")
                    {
                        string nereye_yatirilacak;
                        Console.Write("1-Kendi hesabına, 2-Kredi kartına, Q-Çıkış\n\tİşlem seçiniz: ");
                        nereye_yatirilacak = Console.ReadLine();
                        if (nereye_yatirilacak == "1")
                        {
                            float yatirilacak_tutar;
                            Console.Write("Yatırılacak tutar: ");
                            yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                            bakiye += yatirilacak_tutar;
                            Console.WriteLine("Yeni bakiye: " + bakiye);
                            string devam_mi;
                            Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                            devam_mi = Console.ReadLine();
                            if (devam_mi == "1")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz :)");
                                break;
                            }
                        }
                        if (nereye_yatirilacak == "2")
                        {
                            while (true)
                            {
                                string kart_numarasi;
                                Console.Write("Kart numarası: ");
                                kart_numarasi = Console.ReadLine();
                                if (kart_numarasi == dogru_kart_numarasi)
                                {
                                    break;
                                }
                                if (kart_numarasi != dogru_kart_numarasi)
                                {
                                    kredi_k_giris_hakki--;
                                    Console.WriteLine("Kart numarası hatalı\n");
                                    if (kredi_k_giris_hakki == 0)
                                    {
                                        Console.WriteLine("\tKredi kartınız bloke edildi.");
                                        break;
                                    }
                                }
                            }
                            while (true)
                            {
                                if (kredi_k_giris_hakki == 0)
                                {
                                    break;
                                }
                                if (bakiye >= kart_borcu)
                                {
                                    string kart_borcu_hesaptan_cekilsin_mi;
                                    Console.Write("Banka hesabınızdaki tutar kredi borcunuzu ödemek için yeterli\n\tKredi kartı borcunuzu banka hesabınızdan ödemek ister misiniz? (E->1 H->0:) ");
                                    kart_borcu_hesaptan_cekilsin_mi = Console.ReadLine();
                                    if (kart_borcu_hesaptan_cekilsin_mi == "1")
                                    {
                                        bakiye = bakiye - kart_borcu;
                                        kart_borcu = 0;
                                        Console.WriteLine("Kalan kredi kartı borcu: " + kart_borcu);
                                        Console.WriteLine("Kalan bakiye: "+bakiye);
                                    }
                                    if (kart_borcu_hesaptan_cekilsin_mi == "0")
                                    {
                                        break;
                                    }
                                    if (kart_borcu_hesaptan_cekilsin_mi != "1" || kart_borcu_hesaptan_cekilsin_mi != "0")
                                    {
                                        Console.WriteLine("Hatalı kodlama..");
                                        break;
                                    }
                                }
                                if (bakiye > 0 || kart_borcu > bakiye)
                                {
                                    Console.Write("Hesabınızdaki tutarın bir kısmı kredi kartı borcunuzu ödemeye yardımcı olabilir hesabınızdan kesilmesini kabul ediyor musunuz? (E->1 H->0 Çıkış için-Q): ");
                                    hesaptan_kes_kabul_mu = Console.ReadLine();
                                    if (hesaptan_kes_kabul_mu == "1")
                                    {
                                        Console.Write("Ne kadar kesilsin: ");
                                        ne_kadar_kesilsin = Convert.ToInt32(Console.ReadLine());
                                        if (ne_kadar_kesilsin <= bakiye)
                                        {
                                            bakiye = bakiye - ne_kadar_kesilsin;
                                            kart_borcu = kart_borcu - ne_kadar_kesilsin;
                                            Console.WriteLine("Kalan bakiyeniz: " + bakiye);
                                            Console.WriteLine("Kalan kredi borcunuz: " + kart_borcu);
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine(bakiye + " TL'den fazla miktar girdiniz");
                                            continue;
                                        }
                                    }
                                    if (hesaptan_kes_kabul_mu == "0")
                                    {
                                        break;
                                    }
                                    if (hesaptan_kes_kabul_mu == "Q" || hesaptan_kes_kabul_mu == "q")
                                    {
                                        Console.WriteLine("Yine bekleriz :)");
                                        break;
                                    }
                                    if ((hesaptan_kes_kabul_mu != "1" || hesaptan_kes_kabul_mu != "2") && (hesaptan_kes_kabul_mu != "Q" || hesaptan_kes_kabul_mu != "q"))
                                    {
                                        Console.WriteLine("Hatalı kodlama...");
                                        continue;
                                    }
                                }
                            }
                            if (ne_kadar_kesilsin == 0)
                            {
                                float yatirilacak_tutar;
                                Console.Write("Yatırılacak tutar: ");
                                yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                                if (yatirilacak_tutar > kart_borcu)
                                {
                                    Console.WriteLine("Yatırmak istediğiniz tutar kredi borcunuzdan fazla!!\n\tYatırılacak tutar:");
                                    yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    kart_borcu = kart_borcu - yatirilacak_tutar;
                                    Console.WriteLine("Kalan borç: " + kart_borcu);
                                }
                            }
                            string devam_mi;
                            Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                            devam_mi = Console.ReadLine();
                            if (devam_mi == "1")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz :)");
                                break;
                            }
                        }
                        if (nereye_yatirilacak == "Q")
                        {
                            Console.WriteLine("Yine bekleriz :)");
                            break;
                        }
                    }
                    if (kartli_islem == "3")
                    {
                    string eft_havale;
                    Console.Write("EFT için - 1, Havale için - 2, Çıkış için - Q: ");
                    eft_havale = Console.ReadLine();
                    giris_hakki = 3;
                        while ((eft_havale != "Q" || eft_havale != "q") && eft_havale == "1" || eft_havale == "2")
                        {
                            if (eft_havale == "1")
                            {
                                giris_hakki = 3;
                                string ulke_kodu;
                                Console.Write("Ülke kodu: ");
                                ulke_kodu = Console.ReadLine();

                                string eft_no;
                                Console.Write("EFT no: ");
                                eft_no = Console.ReadLine();

                                if (ulke_kodu == dogru_ulke_kodu && eft_no == dogru_eft_no)
                                {
                                    float eft_ile_gndrlcek_tutar;
                                    Console.Write("EFT ile gönderilecek tutarı giriniz: ");
                                    eft_ile_gndrlcek_tutar = Convert.ToInt32(Console.ReadLine());

                                    if (eft_ile_gndrlcek_tutar <= bakiye)
                                    {
                                        bakiye = bakiye - eft_ile_gndrlcek_tutar;
                                        Console.WriteLine("Para gönderildi\nKalan bakiye: "+bakiye);
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz\n\n");
                                        break;
                                    }
                                }
                                else
                                {
                                    giris_hakki--;
                                    Console.WriteLine("EFT no'yu tekrar yazınız");
                                    continue;
                                    if (giris_hakki == 0)
                                    {
                                        Console.WriteLine("Giriş hakkınız kalmadı eft gönderilemez");
                                        break;
                                    }
                                }
                            }
                            if (eft_havale == "2")
                            {
                                string hesap_no;
                                Console.Write("Hesap no: ");
                                hesap_no = Console.ReadLine();

                                if (hesap_no == dogru_hesap_no)
                                {
                                    float hesaba_gndrlcek_tutar;
                                    Console.Write("Hesaba yatırılacak tutar: ");
                                    hesaba_gndrlcek_tutar = Convert.ToInt32(Console.ReadLine());

                                    if (hesaba_gndrlcek_tutar <= bakiye)
                                    {
                                        bakiye = bakiye - hesaba_gndrlcek_tutar;
                                        Console.WriteLine(hesap_no+" numaralı hesaba "+hesaba_gndrlcek_tutar+" TL transfer edildi.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiye yetersiz\n\tBakiyeniz: " + bakiye);                                            
                                        Console.Write("Yeni tutar girecek misiniz? (E->1, H->0): ");
                                        yeni_tutar = Console.ReadLine();

                                        if (yeni_tutar == "1")
                                        {
                                            Console.Write("Hesaba yatırılacak tutar: ");
                                            hesaba_gndrlcek_tutar = Convert.ToInt32(Console.ReadLine());
                                            if (hesaba_gndrlcek_tutar <= bakiye)
                                            {
                                                bakiye = bakiye - hesaba_gndrlcek_tutar;
                                                Console.WriteLine(hesap_no + " numaralı hesaba " + hesaba_gndrlcek_tutar + " TL transfer edildi.");
                                            }
                                            break;
                                        }
                                        if (yeni_tutar == "0")
                                        {
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    giris_hakki--;
                                    Console.WriteLine("Hesap no hatalı");
                                    if (giris_hakki == 0)
                                    {
                                        Console.WriteLine("Hesap noyu 3 kez hatalı girdiniz");
                                        break;
                                    }
                                }
                            }
                        }
                        if (eft_havale == "Q" || eft_havale == "q")
                        {
                            Console.WriteLine("Yine bekleriz :)");
                        }
                    }
                    if (kartli_islem == "4")
                    {
                        Console.WriteLine("Sayfa arızalı :(");                       
                    }
                    if (kartli_islem == "5")
                    {
                        string odemeler;
                        Console.Write("Elektrik Faturası için - 1, Telefon Faturası için - 2, İnternet Faturası için - 3, Su Faturası için - 4, OGS Ödemeleri için - 5, Çıkış için - Q: ");
                        odemeler = Console.ReadLine();

                        if (odemeler == "1")
                        {
                            string elektrik_abone_no;
                            Console.Write("Abone no giriniz: ");
                            elektrik_abone_no = Console.ReadLine();

                            if (dogru_elktrik_no == elektrik_abone_no)
                            {
                                if (elektrik_borc == 0)
                                {
                                    Console.WriteLine("Borcunuz zaten ödenmiş");
                                    break;
                                }
                                Console.WriteLine("Toplam elektrik borcu: " + elektrik_borc);
                                if (elektrik_borc <= bakiye)
                                {
                                    string odeme_secenegi;
                                    Console.Write("Hesabınızdaki tutar borcu ödemek için yeterli (Hesaptan kesmek için - 1, Nakit ödemek için - 2): ");
                                    odeme_secenegi = Console.ReadLine();

                                    if (odeme_secenegi == "1")
                                    {
                                        bakiye = bakiye - elektrik_borc;
                                        elektrik_borc = 0;
                                        Console.WriteLine("Borcunuz ödendi\n\tKalan bakiye: " + bakiye);
                                        string devam_mi;
                                        Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                                        devam_mi = Console.ReadLine();
                                        if (devam_mi == "1")
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yine bekleriz :)");
                                            break;
                                        }
                                    }
                                    if (odeme_secenegi == "2")
                                    {
                                        while (true)
                                        {
                                            if (elektrik_borc == 0)
                                            {
                                                Console.WriteLine("Borcunuz zaten ödenmiş");
                                                break;
                                            }
                                            int girilen_tutar;
                                            Console.Write("Fatura borcunuzu girin: ");
                                            girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                            if (girilen_tutar < elektrik_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar > elektrik_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar == elektrik_borc)
                                            {
                                                elektrik_borc = 0;
                                                Console.WriteLine("Faturanız ödendi");
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (elektrik_borc > bakiye)
                                {
                                    while (true)
                                    {
                                        if (elektrik_borc == 0)
                                        {
                                            Console.WriteLine("Borcunuz zaten ödenmiş");
                                            break;
                                        }
                                        int girilen_tutar;
                                        Console.Write("Fatura borcunuzu girin: ");
                                        girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                        if (girilen_tutar < elektrik_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar > elektrik_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar == elektrik_borc)
                                        {
                                            elektrik_borc = 0;
                                            Console.WriteLine("Faturanız ödendi");
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Abone bulunamadı");
                                continue;
                            }
                        }
                        if (odemeler == "2")
                        {
                            string telefon_no;
                            Console.Write("Telefon no giriniz: ");
                            telefon_no = Console.ReadLine();

                            if (dogru_telefon_no == telefon_no)
                            {
                                if (telefon_borc == 0)
                                {
                                    Console.WriteLine("Borcunuz zaten ödenmiş");
                                    break;
                                }
                                Console.WriteLine("Toplam telefon borcu: " + telefon_borc);
                                if (telefon_borc <= bakiye)
                                {
                                    string odeme_secenegi;
                                    Console.Write("Hesabınızdaki tutar borcu ödemek için yeterli (Hesaptan kesmek için - 1, Nakit ödemek için - 2): ");
                                    odeme_secenegi = Console.ReadLine();

                                    if (odeme_secenegi == "1")
                                    {
                                        bakiye = bakiye - telefon_borc;
                                        telefon_borc = 0;
                                        Console.WriteLine("Borcunuz ödendi\n\tKalan bakiye: " + bakiye);
                                        string devam_mi;
                                        Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                                        devam_mi = Console.ReadLine();
                                        if (devam_mi == "1")
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yine bekleriz :)");
                                            break;
                                        }
                                    }
                                    if (odeme_secenegi == "2")
                                    {
                                        while (true)
                                        {
                                            if (telefon_borc == 0)
                                            {
                                                Console.WriteLine("Borcunuz zaten ödenmiş");
                                                break;
                                            }
                                            int girilen_tutar;
                                            Console.Write("Telefon borcunuzu girin: ");
                                            girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                            if (girilen_tutar < telefon_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar > telefon_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar == telefon_borc)
                                            {
                                                telefon_borc = 0;
                                                Console.WriteLine("Faturanız ödendi");
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (telefon_borc > bakiye)
                                {
                                    while (true)
                                    {
                                        if (telefon_borc == 0)
                                        {
                                            Console.WriteLine("Borcunuz zaten ödenmiş");
                                            break;
                                        }
                                        int girilen_tutar;
                                        Console.Write("Telefon borcunuzu girin: ");
                                        girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                        if (girilen_tutar < telefon_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar > telefon_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar == telefon_borc)
                                        {
                                            telefon_borc = 0;
                                            Console.WriteLine("Faturanız ödendi");
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Telefon numarası kayıtlı değil");
                                continue;
                            }
                        }
                        if (odemeler == "3")
                        {
                            string internet_abone_no;
                            Console.Write("Abone no giriniz: ");
                            internet_abone_no = Console.ReadLine();

                            if (dogru_internet_abone_no == internet_abone_no)
                            {
                                if (internet_borc == 0)
                                {
                                    Console.WriteLine("Borcunuz zaten ödenmiş");
                                    break;
                                }
                                Console.WriteLine("Toplam internet borcu: " + internet_borc);
                                if (internet_borc <= bakiye)
                                {
                                    string odeme_secenegi;
                                    Console.Write("Hesabınızdaki tutar borcu ödemek için yeterli (Hesaptan kesmek için - 1, Nakit ödemek için - 2): ");
                                    odeme_secenegi = Console.ReadLine();

                                    if (odeme_secenegi == "1")
                                    {
                                        bakiye = bakiye - internet_borc;
                                        internet_borc = 0;
                                        Console.WriteLine("Borcunuz ödendi\n\tKalan bakiye: " + bakiye);
                                        string devam_mi;
                                        Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                                        devam_mi = Console.ReadLine();
                                        if (devam_mi == "1")
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yine bekleriz :)");
                                            break;
                                        }
                                    }
                                    if (odeme_secenegi == "2")
                                    {
                                        while (true)
                                        {
                                            if (internet_borc == 0)
                                            {
                                                Console.WriteLine("Borcunuz zaten ödenmiş");
                                                break;
                                            }
                                            int girilen_tutar;
                                            Console.Write("İnternet borcunuzu girin: ");
                                            girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                            if (girilen_tutar < internet_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar > internet_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar == internet_borc)
                                            {
                                                internet_borc = 0;
                                                Console.WriteLine("Faturanız ödendi");
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (telefon_borc > bakiye)
                                {
                                    while (true)
                                    {
                                        if (telefon_borc == 0)
                                        {
                                            Console.WriteLine("Borcunuz zaten ödenmiş");
                                            break;
                                        }
                                        int girilen_tutar;
                                        Console.Write("Telefon borcunuzu girin: ");
                                        girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                        if (girilen_tutar < telefon_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar > telefon_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar == telefon_borc)
                                        {
                                            telefon_borc = 0;
                                            Console.WriteLine("Faturanız ödendi");
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Telefon numarası kayıtlı değil");
                                continue;
                            }
                        }
                        if (odemeler == "4")
                        {
                            string su_faturasi_no;
                            Console.Write("Abone no giriniz: ");
                            su_faturasi_no = Console.ReadLine();

                            if (dogru_su_faturasi_no == su_faturasi_no)
                            {
                                if (su_faturasi_borc == 0)
                                {
                                    Console.WriteLine("Borcunuz zaten ödenmiş");
                                    break;
                                }
                                Console.WriteLine("Toplam su borcu: " + su_faturasi_borc);
                                if (su_faturasi_borc <= bakiye)
                                {
                                    string odeme_secenegi;
                                    Console.Write("Hesabınızdaki tutar borcu ödemek için yeterli (Hesaptan kesmek için - 1, Nakit ödemek için - 2): ");
                                    odeme_secenegi = Console.ReadLine();

                                    if (odeme_secenegi == "1")
                                    {
                                        bakiye = bakiye - su_faturasi_borc;
                                        su_faturasi_borc = 0;
                                        Console.WriteLine("Borcunuz ödendi\n\tKalan bakiye: " + bakiye);
                                        string devam_mi;
                                        Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                                        devam_mi = Console.ReadLine();
                                        if (devam_mi == "1")
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Yine bekleriz :)");
                                            break;
                                        }
                                    }
                                    if (odeme_secenegi == "2")
                                    {
                                        while (true)
                                        {
                                            if (su_faturasi_borc == 0)
                                            {
                                                Console.WriteLine("Borcunuz zaten ödenmiş");
                                                break;
                                            }
                                            int girilen_tutar;
                                            Console.Write("Su borcunuzu girin: ");
                                            girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                            if (girilen_tutar < su_faturasi_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar > su_faturasi_borc)
                                            {
                                                Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                                continue;
                                            }
                                            if (girilen_tutar == su_faturasi_borc)
                                            {
                                                su_faturasi_borc = 0;
                                                Console.WriteLine("Faturanız ödendi");
                                                break;
                                            }
                                        }
                                    }
                                }
                                if (su_faturasi_borc > bakiye)
                                {
                                    while (true)
                                    {
                                        if (su_faturasi_borc == 0)
                                        {
                                            Console.WriteLine("Borcunuz zaten ödenmiş");
                                            break;
                                        }
                                        int girilen_tutar;
                                        Console.Write("Telefon borcunuzu girin: ");
                                        girilen_tutar = Convert.ToInt32(Console.ReadLine());

                                        if (girilen_tutar < su_faturasi_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura ödemek için yeterli değil\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar > su_faturasi_borc)
                                        {
                                            Console.WriteLine("Girilen tutar fatura tutarından fazla\nLütfen faturadaki tutarı giriniz");
                                            continue;
                                        }
                                        if (girilen_tutar == su_faturasi_borc)
                                        {
                                            su_faturasi_borc = 0;
                                            Console.WriteLine("Faturanız ödendi");
                                            break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Abone numarası kayıtlı değil");
                                continue;
                            }
                        }
                        if (odemeler == "5")
                        {
                            string odeme_secenegi;
                            Console.Write("Takviye, kartınıza hesaptan mı, nakit olarak mı yapılsın? (Hesap için - 1, Nakit için - 2): ");
                            odeme_secenegi = Console.ReadLine();

                            if (odeme_secenegi == "1")
                            {
                                while (true)
                                {
                                    int girilecek_tutar;
                                    Console.Write("Ne kadar takviye yapalım?: ");
                                    girilecek_tutar = Convert.ToInt32(Console.ReadLine());
                                    if (girilecek_tutar <= bakiye)
                                    {
                                        ogs_tutar = ogs_tutar + girilecek_tutar;
                                        bakiye = bakiye - girilecek_tutar;
                                        Console.WriteLine("OGS bakiye = "+ogs_tutar+" TL\n\t"+"Yeni bakiye: "+bakiye);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Bakiyeniz yetersiz");
                                    }
                                    break;
                                }
                            }
                            if (odeme_secenegi == "2")
                            {
                                int girilecek_tutar;
                                Console.Write("Ne kadar takviye yapalım?: ");
                                girilecek_tutar = Convert.ToInt32(Console.ReadLine());
                                ogs_tutar = ogs_tutar + girilecek_tutar;
                                Console.WriteLine("OGS bakiye = " + ogs_tutar);
                            }
                            string devam_mi;
                            Console.Write("Başka bir işlem yapılacak mı?\n\tE->1, H->0: ");
                            devam_mi = Console.ReadLine();
                            if (devam_mi == "1")
                            {
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("Yine bekleriz :)");
                                break;
                            }
                        }
                        if (odemeler == "Q" || odemeler == "q")
                        {
                            Console.WriteLine("Yine bekleriz :)");
                            break;
                        }
                    }
                    if (kartli_islem == "6")
                    {
                        int sifre_tekrar = 0;
                        while (sifre_tekrar < 2)
                        {
                            int yeni_sifre;
                            Console.Write("Doğum tarihi hariç bir şifre oluşturmanızı tavsiye ederiz\n\tYeni Şifre: ");
                            yeni_sifre = Convert.ToInt32(Console.ReadLine());
                            if (yeni_sifre / 100 == 19)
                            {
                                Console.WriteLine("Lütfen bir tarihi simgeleyecek şifre oluşturmayınız.");
                                continue;
                            }
                            else
                            {
                                sifre_tekrar++;
                                int yeni_sifre_tekrar;
                                Console.Write("Yeni Şifre Tekrar: ");
                                yeni_sifre_tekrar = Convert.ToInt32(Console.ReadLine());

                                if (yeni_sifre == yeni_sifre_tekrar)
                                {
                                    Console.WriteLine("Şifreniz oluşturuldu.");                                    
                                    dogru_sifre = Convert.ToString(yeni_sifre);
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("İlk girilen şifre ile ikincisi aynı değil");
                                    continue;
                                }
                            }
                        }
                    }
                    if (kartli_islem == "Q" || kartli_islem == "q")
                    {
                        Console.WriteLine("Çıkış Yapılıyor...");
                        break;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}