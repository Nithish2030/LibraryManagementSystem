using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMgmt
{
    
        public class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
            public bool Available { get; set; }

            // Constructor
            public Book(string title, string author, string isbn, bool available)
            {
                Title = title;
                Author = author;
                ISBN = isbn;
                Available = available;
            }

            // Override
            public override string ToString()
            {
                return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, Available: {Available}";
            }
        }

    
}
