﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksAPI.Models
{
    public class BooksDBContext:DbContext
    {
        public BooksDBContext()
        {
        }
        public BooksDBContext(DbContextOptions<BooksDBContext> options) : base(options)
        {
        }
        public DbSet<Book> Books  { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
