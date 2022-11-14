using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_11_14
{
    public class Author
    {
        public string FirstName{ get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public List<Book> Books{ get; set; }
    }
}
