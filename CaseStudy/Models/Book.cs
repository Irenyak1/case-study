using System;

namespace CaseStudy.Models
{
    public class Book
    {
        
        public int Id {get; set;}

        public string Title {get; set;}

         // Foreign Key
        public int AuthorId { get; set; }
        
        // Navigation property
        public Author Author { get; set; }


    }
}
