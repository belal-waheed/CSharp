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

        }
    }
}
