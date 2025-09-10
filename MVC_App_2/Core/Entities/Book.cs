namespace MVC_App_2.Core.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Name { get; set; }
        public int PublishYear { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
