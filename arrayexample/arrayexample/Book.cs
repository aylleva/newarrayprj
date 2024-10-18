using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace arrayexample
{
    internal class Book
    {
        public string _name;
        public string _author;
        public bool _isAvailable;


        public string Name { get { return _name; } set { _name = value; } }
        public string Author { get { return _author; } set { _author = value; } }   

        public bool Available { get { return _isAvailable; } set { _isAvailable = value; } }


        public Book(string name, string author)
        {
            _name = name;
            _author = author;
           _isAvailable = true;


        }
        public void GetInfo()
        {
            Console.WriteLine($"Name:{_name} Author:{_author} isAvailable:{_isAvailable}");
        }
        
    }
}
