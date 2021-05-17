using System;
using CaseStudy.Models;
using System.Collections.Generic;

namespace CaseStudy.Models
{
    public class Author
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<Book> Books { get; set; }
        
    }
}