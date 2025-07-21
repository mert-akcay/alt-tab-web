// Değişkenler
// değişken tipi
// Tam sayılar
// byte 0-255   1 byte
byte b;
b = 255;
byte a = 0;
//    short -32,768 to 32,767  2 byte
short s = 32700;
//    int -2,147,483,648 to 2,147,483,647  4 byte
int i = 2147483647;
//    long -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807  8 byte

//Ondalıklı Sayılar
//    float 1.5 x 10^-45 to 3.4 x 10^38  4 byte
float f = 3.40F;

//    double 5.0 x 10^-324 to 1.7 x 10^308  8 byte
double d = 1.79769313;

//Mantıksal Tipler
bool abc = true;

// Karakter Tipi
//    char 0 to 65,535  2 byte
char c = 'A';
Console.WriteLine(c);
//    string 0 to 2 billion Unicode characters  2 byte per character
string str = "Hello, World!";

// Tarih
//    DateTime 1/1/0001 12:00:00 AM to 12/31/9999 11:59:59 PM  8 byte
DateTime dt = DateTime.Now;
Console.WriteLine(dt);

// Object
//    object 0 to 2 billion Unicode characters  2 byte per character
object obj = 1242;
Console.WriteLine(obj);


// Operatorler
// Aritmetik Operatörler
int x = 10;
int y = 9;

int sum = x + y; // Toplama
int difference = x - y; // Çıkarma
int product = x * y; // Çarpma
int quotient = x / y; // Bölme 
int remainder = x % y; // Modül
                       // 1 arttırmak veya 1 azalmak
x++;
x--;
Console.WriteLine(remainder);

// Atama Operatörleri
int a1 = 5;
a1 = 7;
//a1 = a1 + 5;
a1 += 5;
//a1 = a1 * 5;
a1 *= 5;
//a1 = a1 / 5;
a1 /= 5;
//a1 = a1 % 5;
a1 %= 5;
Console.WriteLine(a1);

// Karşılaştırma Operatorleri
// hep bool bir değer verir.
//Eşit mi?
int x1 = 5;
int y1 = 5;
bool isEqual = x1 == y1;
//Eşit değil mi?
bool isNotEqual = x1 != y1;
//Büyük mü?
bool isGreater = x1 > y1;
//Büyük veya eşit mi?
bool isGreaterOrEqual = x1 >= y1;
//Küçük mü?
bool isLess = x1 < y1;
//Küçük veya eşit mi?
bool isLessOrEqual = x1 <= y1;

// Mantıksal Operatörler
// VE
// &&
bool condition1 = false;
bool condition2 = false;
bool andResult = condition1 && condition2;

// VEYA
// ||
bool orResult = condition1 || condition2;

Console.WriteLine(orResult);

// TERS
// !
bool condition3 = !condition1;


// Koşul İfadeler
// If-Else
bool conditionIf = true;
if (conditionIf)
{
    // Do something if condition is true
}
else
{
    // Do something if condition is false
}

int yas = 19;
int yas2 = 20;
if (yas < 18 || yas2 > 18)
{
    Console.WriteLine("Reşit Değilsiniz");
}
else if (yas < 20)
{
    Console.WriteLine("20 yaşından küçüksünüz.");
}
else
{
    Console.WriteLine("Reşitsiniz");
}

// Switch Case
int number = 1;
switch (number)
{
    case 1:
    case 15:
    case 20:
        Console.WriteLine("Number is 1");
        break;
    case 2:
        Console.WriteLine("Number is 2");
        break;
    case 3:
        Console.WriteLine("Number is 3");
        break;
    default:
        Console.WriteLine("Number is not 1 or 2");
        break;
}

// Ternary Operator
string sonuc;

if (yas > 18)
{
    sonuc = "Reşitsiniz";
}
else
{
    sonuc = "Reşit değilsiniz";
}

sonuc = yas > 18 ? "Reşitsiniz" : "Reşit değilsiniz";
 


// Girilen 4 sayının ortalamasını veren bir program
Console.WriteLine("Lütfen 1. sayıyı giriniz:");
int sayi1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 2. sayıyı giriniz:");
int sayi2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 3. sayıyı giriniz:");
int sayi3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Lütfen 4. sayıyı giriniz:");
int sayi4 = Convert.ToInt32(Console.ReadLine());

int toplam = sayi1 + sayi2 + sayi3 + sayi4;
double ortalama = toplam / 4.0;
Console.WriteLine("Girilen sayıların ortalaması: " + ortalama);