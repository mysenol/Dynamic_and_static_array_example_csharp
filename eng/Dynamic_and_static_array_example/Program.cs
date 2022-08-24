using System;
using System.Collections;

public class Program
{
    public static void Main()
    {       
        // 3 elemanlı statik dizi oluşturma
        // int[] sayilar = new int[3];

        int girilecekelemansayisi=5;         
        int[] sayilar = new int[girilecekelemansayisi];

        // iki basamaklı ve tek basamaklı sayıları ayırmak için iki ayrı dinamik dizi.
        ArrayList tekbasamaklisayilar = new ArrayList();
        ArrayList ikibasamaklisayilar = new ArrayList();

        // Dizinin içerisini kullancıdan alınan sayılarla dolduran yapımız.
        for (int i = 0; i < girilecekelemansayisi; i++)
        {
            int ui = i + 1;
            Console.Write(ui.ToString() + ". Sayıyı giriniz: ");
            sayilar[i] = Convert.ToInt32(Console.ReadLine());
        }

        //Girilen sayıların basamağı kontrol ediyor ve sayı aralağına göre ilgili kümeye ekliyor. 
        foreach (int sayi in sayilar)
        {
            if (sayi < 100 && sayi > 10) { ikibasamaklisayilar.Add(sayi); }
            else if (sayi < 10 && sayi > 0) { tekbasamaklisayilar.Add(sayi); }
        }

        //Statik dizinin içerisindeki sayı değerlerini yazdırıyor. Girilen sayıları listeliyor.
        int sid = 1;
        Console.WriteLine("\n------------------ mysenol.com -----------------------");
        Console.WriteLine("\n" + "Girdiğiniz sayılar:" + "\n");
        foreach (int x in sayilar)
        {
            Console.WriteLine(sid.ToString() + ". Girdiğiniz sayı: " + x);
            sid++;
        }
        //Dinmamik dizileri listeleyen sınıfa; dizileri, göndererek kodu çalıştırıyor.
        Diziyiyazdir("Tek basamaklı sayılar dizisi:", tekbasamaklisayilar);
        Diziyiyazdir("İki basamaklı sayılar dizisi:", ikibasamaklisayilar);

        //Dizileri sıralayarak en küçük değeri buluyoruz.
        //Dizileri sıralayıp; Reverse() (fonksiyonu) ile dizi sıralamasını tersine çevirerek, en büyük değeri buluyoruz. 
        //Diziler sıralandığında istediğimiz değer ilk elemanının değeri oluyor. Buda 0. indeksteki eleman. 
        Istenilenislem(tekbasamaklisayilar, ikibasamaklisayilar);

      
        Console.ReadKey();
    }

    // Dinamik dizimizi yazdıran sınıfımız.
    public static void Diziyiyazdir(string baslik, ArrayList Gonderilendizi) //IEnumerable
    {
        Console.WriteLine("\n {0}", baslik);

        if (Gonderilendizi.Count > 0)
        {
            int id = 1;
            foreach (int sayi in Gonderilendizi)
            {
                Console.WriteLine(" {0}. Eleman: {1}", id, sayi);
                id++;
            }
            id = 1;
        }
        else
        {
            Console.WriteLine("\n Malesef, ilgili dizide hiç elemanınız yok.");
        }

    }

    // İstenilen matematiksel işlem:
    public static void Istenilenislem(ArrayList tekbassayilar, ArrayList ikibassayilar)
    {
        //tek basamaklı en küçük sayıyı alma - A-Z:
        tekbassayilar.Sort();
        Console.WriteLine("\n Girilen tek basamaklı en küçük sayı: {0}", tekbassayilar[0]);

        //iki basamaklı en büyük sayıyı alma - A-Z + Reverse():
        ikibassayilar.Sort();
        ikibassayilar.Reverse();
        Console.WriteLine("\n Girilen iki basamaklı en büyük sayı: {0}", ikibassayilar[0]);

        int farkislemisonucu=Convert.ToInt32(ikibassayilar[0])-Convert.ToInt32(tekbassayilar[0]);
        Console.WriteLine("\n Girilen değerler arasında; \n iki basamaklı en büyük sayı ile tek basamaklı en küçük sayının farkı: {0}", farkislemisonucu);
    }
}