using System.ComponentModel.DataAnnotations;

namespace BookStoreCodeFirst.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public required string Title { get; set; }
        public string? Author { get; set; }
        public decimal Price { get; set; }
    }
}