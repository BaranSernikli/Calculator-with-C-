using System;

class Program
{
    static void Main()
    {

        Console.WriteLine("Hesap Makinesi Uygulamasına Hoşgeldiniz!");

        Console.Write("Birinci sayıyı girin: ");
        var Sayi1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("İkinci sayıyı girin: ");
        var Sayi2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yapmak istediğiniz işlemi seçin (+, -, *, /): ");
        var Sonuc = Console.ReadLine();

        if (Sonuc == "+")
            Console.WriteLine("Sonuç: " + (Sayi1 + Sayi2));
        else if (Sonuc == "-")
            Console.WriteLine("Sonuç: " + (Sayi1 - Sayi2));
        else if (Sonuc == "*")
            Console.WriteLine("Sonuç: " + (Sayi1 * Sayi2));
        else if (Sonuc == "/")
            Console.WriteLine(Sayi2 == 0 ? "Hata! Bir sayıyı sıfıra bölemezsiniz." : "Sonuç: " + (Sayi1 / Sayi2));
        else
            Console.WriteLine("Geçersiz işlem!");

        Console.WriteLine("Başka bir işlem yapmak ister misiniz? (Evet/Hayır)");
        if (Console.ReadLine().ToLower() == "evet")
            Main(); 
        else
            Console.WriteLine("Hesap Makinesi Uygulamasından çıkılıyor...");
    }
}
