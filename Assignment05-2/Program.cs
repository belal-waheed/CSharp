namespace Assignment05_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
             Add a private string password = "secret"; field to a Book class. Try to print it from Main
             (outside the class). What happens, and why?
             */
            
            // This will cause a compilation error because the password field is private and cannot be accessed from outside the Book class.
            //Console.WriteLine(Book.password); 
            
            #endregion


            #region 2
            /*
             Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
             */


            Book book = new Book();
            // This will compile and print 5 because the copiesInStock field is internal and can be accessed from the same Project.
            Console.WriteLine(book.copiesInStock);
            #endregion
        }
    }
}
