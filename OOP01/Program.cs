namespace OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1
            /*
             Question 1
            Consider the following code:

            public struct DeliveryAddress
            {
                public string City; public string Street;
            }

            public class Customer
            {
                public string Name;
            }
             */
            //a)  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified?

            //When a struct is copied, a new instance is created, and modifying the copy does not affect the original, because its value type.

            //b)  What happens when a Customer variable is copied into another variable and one variable modifies the object?

            // both variables reference the same object in memory.so it will affect the original object because its reference type.
            #endregion

            #region 2
            /*
            Consider the following struct:
            public struct Shipment
            {
                public string Description;
                public double Weight; 
                public decimal DeliveryFee;
            }
a) a) Identify at least three problems with this design from an encapsulation perspective.
//No data protection so any code can modify the fields directly.
//No validation
//
b) b) How can private fields and public properties improve this design?
Private fields hide the internal data, while public properties provide controlled access. 
Properties can also include validation and other logic before allowing values to be changed.
             */
            #endregion

            #region part02-1
            /*
            DeliveryAddress deliveryAddress = new DeliveryAddress("New York", "Main Street", 123);
            DeliveryAddress fullAddress = deliveryAddress;
            fullAddress.City = "Los Angeles";
            Console.WriteLine("original the same");
            Console.WriteLine(deliveryAddress.GetFullAddress());
            Console.WriteLine("modified");
            Console.WriteLine(fullAddress.GetFullAddress());
            */
            #endregion
        }
    }
}
