namespace for_dongusu;
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"i degeri: {i} Ben kendime inanıyorum - Bu yazılım işini yapacağım.");
        }


        // ÖDEV 2 (1-20) Arasındaki sayıları konsol ekranına yazdırınız.

        for (int i = 1; i <= 20; i++)
        {
            Console.WriteLine($"i degeri:{i}");
        }

        // ÖDEV 3 (1-20) arasındaki çift sayıları ekrana yazdırınız.
        for (int i = 1; i < 20; i++)
        {
            if (i % 2 == 0) // i çiftse
            {
                Console.WriteLine($"i degeri:{i}.");
            }
        }

        // ÖDEV 4 (50 İLE 150) ARASINDAKİ SAYILARIN TOPLAMINI EKRANA YAZDIRIN.

        int toplam = 0;
        for (int i = 50; i <= 150; i++)
        {
            toplam += i;// toplam = toplam + i;
        }

        Console.WriteLine($"50 ile 150 arasındaki sayıların toplamı:{toplam}");
    }
      
    
}



      // ÖDEV 5 İ YAPMAYA ÇALIŞTIĞIMDA SAYFA ÇALIŞTIRMIYOR . BİR PARANTEZ HATASI YAPILDI SANIRIM ÇÖZEMİYORUM.
      

   

    