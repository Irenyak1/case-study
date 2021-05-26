using System;
using CaseStudy.Models;
using Microsoft.EntityFrameworkCore; // ORM tool that coverts models into columns in the database

namespace CaseStudy.Data
{
    public class LibraryContext : DbContext

    {
        public LibraryContext(DbContextOptions options) :base(options){
        
        }
        public DbSet<Book> Books {get;set;}
        public DbSet<Author> Authors {get;set;}
        
    }
}