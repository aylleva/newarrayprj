namespace arrayexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookLibrary library = new BookLibrary( "Axundov");


            Book book1 = new Book("lale","Mirze Feteli Axundov");
            Book book2 = new Book("sir", "Nesimi");

            Book book3 = new Book("sevgi", "Nesimi");

            

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            library.BorrowBook("sir");



            library.ShowAll();
            library.SearchByAuthor("Nesimi");


        }
    }
}