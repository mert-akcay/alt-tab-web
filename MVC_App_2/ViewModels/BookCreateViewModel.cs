using MVC_App_2.Core.Entities;

namespace MVC_App_2.ViewModels
{
    public class BookCreateViewModel
    {
        public Book Book { get; set; }
        public List<Author> Authors { get; set; }
    }
}
