using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment05_2
{
    internal class Book
    {
        private string password = "secret"; 
        internal int copiesInStock = 5;
        public string Title="Hola";
        public Genre Genre { get; set; }
    }
}
