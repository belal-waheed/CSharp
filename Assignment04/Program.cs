namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Create a one-dimensional array double[] prices with the values 25.5, 40.0, 33.75. Print
            //the second price(index 1).

            /*
            double[] prices = { 25.5, 40.0, 33.75 };
            Console.WriteLine(prices[1]);
            */
            #endregion

            #region Q2
            /*
             Create a 2x2 multidimensional array int[,] shelfCopies where shelf 0 has 3, 5 copies and
shelf 1 has 1, 4 copies. Print the number of copies on shelf 1, slot 0.
             */

            /*
            int[,] shelfCopies = { { 3, 5 }, { 1, 4 } };
            Console.WriteLine(shelfCopies[1, 0]);
             */

            #endregion
            #region Q3
            /*
             Write a method called PrintWelcomeMessage that takes no parameters and prints
"Welcome to the Library!". Call it from Main.
             */

            /*
            void PrintWelcomeMessage()
            {
                Console.WriteLine("Welcome to the Library!");
            }
            PrintWelcomeMessage();
            */

            #endregion

            #region Q4
            /*
             Write a method PrintBookTitle(string title) that prints "Book title: " + title. Call it with
"Clean Code".
             */

            /*
            void PrintBookTitle(string title)
            {
                Console.WriteLine("Book title: " + title);
            }
            PrintBookTitle("Clean Code");
            */
            #endregion

            #region Q5
            /*
             Write a method AddBonusPages(int pages) that adds 50 to pages. Call it with a variable
int pages = 400; and print pages afterward. What do you expect to see, and why?
             */
            //static void AddBonusPages(int pages)
            //{
            //    pages += 50;
            //}
            //int pages = 400;

            //AddBonusPages(pages);

            //Console.WriteLine(pages);   // Output: 400

            #endregion


            #region Q6
            /*
             Write a method ApplyDiscount(double[] prices) that subtracts 5 from prices[0]. Call it
with double[] prices = { 25.5, 40.0 }; and print prices[0] afterward. What do you expect to
see, and why?
             */

            //static void ApplyDiscount(double[] prices)
            //{
            //    prices[0] -= 5;
            //}
            //double[] prices = { 25.5, 40.0 };

            //ApplyDiscount(prices);

            //Console.WriteLine(prices[0]);
            // Output: 20.5
            #endregion



        }
    }
}
