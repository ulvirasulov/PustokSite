﻿namespace Pustok.Models
{
    public class BookCategory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; }


    }
}
