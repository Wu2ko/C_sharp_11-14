using System;
using System.Collections.Generic;
using System.Text;

namespace C_sharp_11_14
{
    public class Magazine : Publication
    {
        public Magazine(string isbn) : base(isbn)
        {

        }

        public bool IsMagazine =>true; 
        public bool IsAvailable { get; set; }
    }
}
