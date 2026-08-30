namespace CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            
            //1.Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only
            //if pages is greater than 300 and isAvailable is true.Use the && operator.
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable ) Console.WriteLine("You can borrow this book");

            #endregion



        }
    }
}
