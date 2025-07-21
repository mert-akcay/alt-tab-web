//// Girilen 3 sayıdan 100'e en yakın olanı bulan program
//Console.WriteLine("1. Sayıyı Giriniz:");
//int sayi1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("2. Sayıyı Giriniz:");
//int sayi2 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("3. Sayıyı Giriniz:");
//int sayi3 = Convert.ToInt32(Console.ReadLine());

//int minNumber = sayi1;
//int minDifference = Math.Abs(sayi1 - 100);

//if (Math.Abs(sayi2 - 100) < minDifference)
//{
//    minNumber = sayi2;
//    minDifference = Math.Abs(sayi2 - 100);
//}

//if (Math.Abs(sayi3 - 100) < minDifference)
//{
//    minNumber = sayi3;
//    minDifference = Math.Abs(sayi3 - 100);
//}

//Console.WriteLine("100'e en yakın sayı: " + minNumber + "'dır.");
//// String Interpolation
//Console.WriteLine($"100'e en yakın sayı {minNumber}'dır.");

// Döngüler
// i = 1
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine(i);
//}

// 100'e kadar olan çift sayıları yazdırma
//for (int i = 0; i < 101; i++)
//{
//    if (i % 2 == 0) //i çift ise
//    {
//        Console.WriteLine(i);
//    }
//}

//for (int i = 1; i < 101; i += 2)
//{
//    Console.WriteLine(i);
//}

// while döngüsü
//int sayac = 0;
//while(sayac < 100)
//{
//    Console.WriteLine(sayac);
//    sayac++;
//}

//// foreach döngüsü
//string[] isimler = { "Ahmet", "Mehmet", "Ayşe", "Fatma" };
//string abc = isimler[0];
//Console.WriteLine(abc);

//for (int i = 0; i < isimler.Length; i++)
//{
//    Console.WriteLine(isimler[i]);
//}

//foreach (string isim in isimler)
//{
//    Console.WriteLine(isim);
//}

//1'den başlayarak girilen sayı kadar tek sayı ve bunların toplamını bulan program
//Console.WriteLine("Lütfen bir sayı giriniz.");
//int adet = Convert.ToInt32(Console.ReadLine());

//int toplam = 0;
//int yazdirilanAdet = 0;
//int sayi = 1;

//while (yazdirilanAdet < adet)
//{
//    Console.WriteLine(sayi);
//    toplam += sayi;
//    yazdirilanAdet++;
//    sayi += 2;
//}

//Console.WriteLine($"Sayıların toplamı: {toplam}");

// Girilen sayının faktöriyelini hesaplayan program
// 5! = 5 * 4 * 3 * 2 * 1 

//Console.WriteLine("Lütfen bir sayı giriniz:");
//int sayi = Convert.ToInt32(Console.ReadLine());

//int carpim = 1;
//for (int i = sayi; i > 1; i--)
//{
//    //carpim = carpim * i;
//    carpim *= i; // Kısaltılmış çarpma işlemi
//    Console.WriteLine($"Mevcut çarpım {carpim}");
//}
//Console.WriteLine($"{sayi} sayısının faktoriyeli {carpim} değerine eşittir.");

//// Diziler
//string[] abcs = {"asdsa","asdas", "asdas"};
////abcs[0] = "asdsa"

//string[] isimler = new string[5];
//isimler[0] = "Ahmet";
//isimler[1] = "Mehmet";
////isimler[0] //Boş gelir

//int[] sayilar = new int[5];
//sayilar[0] = 1;

//string isim = "Mert";
//Console.WriteLine(isim[0]); // M

// Try-Catch-Finally
//try
//{
//    int sayi1 = Convert.ToInt32(Console.ReadLine());
//    Console.WriteLine($"Girdiğiniz sayı: {sayi1}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine("Bir hata oluştu");
//}
//finally
//{
//    Console.WriteLine("Try-Catch bloğu tamamlandı.");
//}

// Bir sayıdaki rakamların toplamını bulan program
//Console.WriteLine("Lütfen bir sayı giriniz:");
//string sayiStr = Console.ReadLine();
//int toplam = 0;

//for (int i = 0; i < sayiStr.Length; i++)
//{
//    string sayi = sayiStr[i].ToString();
//    toplam += Convert.ToInt32(sayi);
//}

//Console.WriteLine($"Girdiğiniz sayının rakamlarının toplamı: {toplam}");

// Girilen kelimenin tersini yazdıran program
//Console.WriteLine("Lütfen bir kelime giriniz:");
//string kelime = Console.ReadLine();

//string tersKelime = "";
//for (int i = kelime.Length -1; i >= 0; i--)
//{
//    tersKelime += kelime[i];
//}
//Console.WriteLine($"Girdiğiniz kelimenin tersi: {tersKelime}");

// Metotlar (fonksiyonlar)
// DRY: Do not Repeat Yourself
// erişim belirleyici dönüs türü metotAdı(parametreler)
//{
// Metot içeriği
//}
// Girilen iki sayının toplamını hesaplayan metot
// camelCase ve PascalCase
int Topla(int sayi1, int sayi2)
{
    int toplam = sayi1 + sayi2;
    return toplam;
}

int sonuc = Topla(3, 5);
Console.WriteLine($"Toplam: {sonuc}");
