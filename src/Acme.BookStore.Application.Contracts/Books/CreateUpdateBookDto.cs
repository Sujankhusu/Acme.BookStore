using System;
using System.ComponentModel.DataAnnotations;

namespace Acme.BookStore.Books
{
    public class CreateUpdateBookDto
    {
        public Guid? TenantId { get; set; }

        public Guid AuthorId { get; set; }

        public string Name { get; set; }

        public BookType Type { get; set; } 
      
        public DateTime PublishDate { get; set; } 

        public float Price { get; set; }
    }
}
