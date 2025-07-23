// OOP (Object Oriented Programming (Nesne Yönelimli Programlama))
// isim, soyisim, email, şifre

// class (sınıf)

// degisken_turu degisken_adi = deger;  
//using oop;


using oop;

var kullanici = new User();
kullanici.FirstName = "Ahmet";
kullanici.SurName = "Yılmaz";
//kullanici.Email = "";
//kullanici.Password = "12345";
//kullanici.Age = 30;
kullanici.BilgileriYazdir();

// new'leme işlemine yeni bir nesne örneği oluşturma denir. (yeni bir instance oluşturma)   
var kullanici2 = new User();
kullanici2.FirstName = "Mehmet";
kullanici2.SurName = "Demir";
//kullanici2.Email = "";  
//kullanici2.Password = "54321";
//kullanici2.Age = 25;

var kullanici3 = new User("Ayşe", "Demir");

var kullanici4 = new User();

// Yeniden kullanılabilirlik
// Anlaşılabilirlik
// Kolay bakım
// Geliştirilebilirlik


// Access Modifiers (Erişim Belirleyiciler)
// public -> her yerden erişilebilir
// private -> sadece tanımlandığı sınıf içinde erişilebilir
// protected -> sadece tanımlandığı sınıf ve türetilen sınıflar içinde erişilebilir
// internal -> sadece aynı assembly (proje) içinde erişilebilir
// protected internal -> hem aynı assembly içinde hem de türetilen sınıflar içinde erişilebilir

// Encapsulation
var bankAccount = new BankAccount();
//bankAccount.Balance = 5412321;
bankAccount.IncreaseBalance(500);

// Inheritance (Kalıtım)
// Kod tekrarını azaltmak için
//var animal = new Animal();
//animal.Eat();

var dog = new Dog();
dog.Eat();

// Polymorphism (Çok biçimlilik)
// Aynı metod adı ile farklı işlevler gerçekleştirme
var shape = new Shape();
shape.Draw();

var circle = new Circle();
circle.Draw();

// Abstraction
// Interface , Abstract Class ( Soyut class )
// Gereksiz detayları gizleyip önemli kısımları ortaya çıkarma