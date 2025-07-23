namespace oop
{
    public abstract class Animal
    {
        public int Height { get; set; }

        public void Eat()
        {
            Console.WriteLine("Yemek yiyor.");
        }
    }

    public class Dog : Animal
    {
        public void Havla()
        {
            Console.WriteLine("Hav");
        }
    }

    public class Cat : Animal
    {
        public void Miyavla()
        {
            Console.WriteLine("Miyav");
        }
    }
}
