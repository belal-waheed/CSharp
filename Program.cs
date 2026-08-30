using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1.Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only
            //if pages is greater than 300 and isAvailable is true.Use the && operator.

            /*
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable ) Console.WriteLine("You can borrow this book");
           */

            #endregion

            #region Q2

            //Given string title = "Refactoring";, write a switch statement that prints "Great choice!" if
            //the title is "Clean Code", "Nice pick!" if it's "Refactoring", and "Never heard of it" for
            //anything else.

            /*
            string title= "Refactoring";
            switch (title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            */

            #endregion


            #region Q3

            //3. Given int pages = 464;, use the ternary operator to store "Long Book" or "Short Book"
            //into a variable sizeLabel(same rule as question 6: long if pages > 300).

            /*
            int pages=464;
            string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
            */

            #endregion

            #region Q4

            //4. Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            //use a for loop to print each book with its position number, like 1.Clean Code.

            /*
             string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for (int i=0;i< books.Length; i++)
            {
                Console.WriteLine($"{i + 1}.{books[i]}");
            }
            */

            #endregion

            #region Q5

            //5. Using the same books array, use a while loop to print every book title.
            /*
             
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            int i = 0;
            while (i < books.Length)
            {
                Console.WriteLine(books[i]);
                i++;
            }

            */
            #endregion

            #region Q6
            //6. Write a do-while loop that prints "Checking book..." exactly 3 times.

            /*
            int i = 0;
            do
            {
                Console.WriteLine("Checking book...");
                i++;
            } while (i < 3);

            */
            #endregion

            #region Q7
            //7. Using the same books array, use a foreach loop to print every book title.
            /*
            
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

           */
            #endregion

            #region Q8

            //8. Using the same books array, loop through it and print each title, but stop completely
            //(break) once you reach "Refactoring".
            /*
            
            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }
                Console.WriteLine(book);
            }

            */
            #endregion

            #region Q9
            //9. Using the same books array, print every title except "The Pragmatic Programmer" (skip it
            //with continue, don't stop the loop).
            /*

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }
                Console.WriteLine(book);
            }

            */
            #endregion

        }
    }
}
