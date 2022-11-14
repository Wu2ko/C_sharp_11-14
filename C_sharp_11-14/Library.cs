using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_11_14
{
    public class Library
    {
        public Library(Address address)
    {
        Address = address;
        Books = new List<Book>();
        Magazines = new List<Magazine>();
    }
    public Address Address { get; set; }
    public List<Book> Books { get; set; }
    public List<Magazine> Magazines { get; set; }

}
}

