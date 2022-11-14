using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_11_14
{
    public class Book : Publication
    {
        public Book(string isbn):base(isbn)
        {

        }
   
        public Author Author { get; set; }
        public Genre Genre { get; set; }
        public bool IsAvailable { get; set; }

        

    }

}
