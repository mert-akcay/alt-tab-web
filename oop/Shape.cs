namespace oop
{
    // : sonrasında class kulanılırsa miras
    // : sonrasında interface kullanılırsa imlepente etmek
    public class Shape : IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void Draw()
        {

        }
    }

    public class Circle : Shape
    {
    }

    public interface IShape
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public void Draw();
    }
}
