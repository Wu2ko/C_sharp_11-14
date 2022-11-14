using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_11_14
{
    public class Flyer : Publication
    {
        public Flyer(string isbn) : base(isbn)
        {

        }
        public string Title { get; set; }
        public string Description { get; set; }
         // public string Title { get; set; }
        public bool IsAvailable { get; set; }
    }
}
