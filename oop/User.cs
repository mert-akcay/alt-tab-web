namespace oop
{
    // Class'lar aslında bir veri tipidir.
    public class User
    {
        // isim, soyisim, email, şifre
        // property (özellik)
        public string FirstName { get; set; } // getter ve setter
        public string SurName { get; set; }
        //public string Email { get; set; }
        //public string Password { get; set; }
        public int Age { get; set; }
        protected string KimlikSeriNumarasi { get; set; } // private erişim belirleyici

        // constructor (yapıcı metod)
        public User()
        {
            Console.WriteLine("Boş Constructor kullanıcı oluşturuldu.");    
        }

        public User(string firstName, string surName)
        {
            Console.WriteLine("Dolu Constructor kullanıcı oluşturuldu.");

            FirstName = firstName;
            SurName = surName;
        }

        // this keyword
        public User(string firstName, int age)
        {
            Console.WriteLine("Dolu Constructor kullanıcı oluşturuldu.");

            //this.BilgileriYazdir(); 
            //FirstName = firstName;
            //this.FirstName = FirstName;
            FirstName = firstName;
            Age = age;
        }

        // metodlar
        public void BilgileriYazdir()
        {
            Console.WriteLine($"İsim: {FirstName}, Soyisim: {SurName}");
        }
    }
}
