namespace Assignment05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();


            #region 1
            /*
             Add a private string password = "secret"; field to a Book class. Try to print it from Main
             (outside the class). What happens, and why?
             */

            // This will cause a compilation error because the password field is private and cannot be accessed from outside the Book class.
            //Console.WriteLine(book.password); 

            #endregion


            #region 2
            /*
             Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
             */

            // This will compile and print 5 because the copiesInStock field is internal and can be accessed from the same Project.
            //Console.WriteLine(book.copiesInStock);
            #endregion

            #region 3
            /*
             Add a public string Title; field to Book. Set it and print it from Main. 
            */
            //Console.WriteLine(book.Title);

            #endregion

            #region 4
            /*
             Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, 
             assign it Genre.Science, and print it.
            */
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);

            #endregion
        }
    }
}
