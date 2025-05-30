using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;


namespace NetCoreMVCLab03.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string? Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string? Summary { get; set; }

        // This method returns a list of books
        public List<Book> GetBookList()
        {
            // Initialize the list of books
            List<Book> books = new List<Book>
            {
                new Book(){ Id = 1, Title = "Chi pheo", AuthorId = 1, GenreId = 1, Image = "images/chipheo.jpg", Summary = "Summary of Chi pheo", TotalPage = 250},
                new Book(){ Id = 2, Title = "The Great Gatsby", AuthorId = 2, GenreId = 2, Image = "images/TheGreatGatsby.jpg", Price = 30000, Summary = "Summary of The Great Gatsby", TotalPage = 180},
                new Book(){ Id = 3, Title = "Moby Dick", AuthorId = 3, GenreId = 3, Image = "images/MobyDick.jpg", Price = 60000, Summary = "Summary of Moby Dick", TotalPage = 500},
                new Book(){ Id = 4, Title = "The secret garden", AuthorId = 4, GenreId = 4, Image = "images/TheSecretGarden.jpg", Price = 60000, Summary = "Summary of The secret garden", TotalPage = 500}
            };
            return books;
        }

        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Nam Cao"},
            new SelectListItem {Value = "2", Text = "Ngo Tat To"},
            new SelectListItem {Value = "3", Text = "Adamkhoom"},
            new SelectListItem {Value = "4", Text = "No name"}
        };

        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value = "1", Text = "Truyen tranh" },
            new SelectListItem {Value = "2", Text = "Van hoc duong dai"},
            new SelectListItem {Value = "3", Text = "Tieu thuyet"},
            new SelectListItem {Value = "4", Text = "Truyen cuoi"}
        };

        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
    }
}
