using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayexample
{
    internal class BookLibrary
    {
        public string _name;

        public Book[] books=new Book[0];

        public string Name { get { return _name; } set { _name = value; } } 
        
        public BookLibrary(string name)
        {
           _name = name;
        }

        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length-1] = book; 
        }

        public void RemoveBook(string name)
        {
            Book[] newarray=new Book[books.Length-1];
            int j = 0;
            for(int i=0; i<books.Length; i++)
            {
              if(books[i].Name != name)
                {
                    newarray[j]=books[i];
                    j++;
                }
              books=newarray;
            }
        }
        public void ShowAll()
        {
            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"Name:{books[i].Name} Author:{books[i].Author} Isavailable:{books[i]._isAvailable}");
            }
        }


        public void  BorrowBook(string name)
        {
            
            for(int i=0; i<books.Length; i++)
            {
                if(books[i].Name != name )
                {
                    books[i]._isAvailable = false;


                    
                }
               
            }
        }

        public void  ReturnBook(string name)
        {
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i].Name == name)
                {
                    books[i]._isAvailable = true;


                }
            }
        }

        public void SearchByAuthor(string author)
        {
            
            for(int i = 0; i < books.Length; i++)
            {
                if (books[i].Author == author)
                {
                    Console.WriteLine(books[i].Name);
                   
                }
              

            }
        }
       

    }
}
