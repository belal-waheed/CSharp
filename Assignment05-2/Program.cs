using Microsoft.VisualBasic;
using System.Drawing;

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

            #region 5
            /*
             Using the Genre enum above, print the underlying int value of 
             Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
            */

            //Console.WriteLine($"Fiction = {(int)Genre.Fiction}");
            //Console.WriteLine($"NonFiction = {(int)Genre.NonFiction}");
            //Console.WriteLine($"Science = {(int)Genre.Science}");

            #endregion

            #region 6
            /*
             Given int genreNumber = 1;, cast it into a Genre value and print the result. 
            */

            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine($"Casted value: {genre}");

            #endregion

            #region 7
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //Genre genre = Genre.Fiction;
            //string genreString = genre.ToString();
            //Console.WriteLine(genreString);

            #endregion

            #region 8
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result.

            //string genreText = "Science";
            //Genre parsedGenre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(parsedGenre);

            #endregion

            #region 9
            //Given string genreText = "Mystery"; (not a valid Genre value), use Enum.TryParse() to 
            //attempt the conversion.Print "Unknown genre" if it fails.

            string genreText = "Mystery";
            if (Enum.TryParse<Genre>(genreText, out Genre result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }

            #endregion
        }
    }
}
