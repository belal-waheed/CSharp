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
            DeliveryCenter center = new DeliveryCenter();

            // Shipment 1
            Console.WriteLine("Enter Shipment 1 Data");

            Console.Write("Tracking Code: ");
            string code1 = Console.ReadLine();

            Console.Write("Description: ");
            string description1 = Console.ReadLine();

            Console.Write("Weight: ");
            double weight1 = double.Parse(Console.ReadLine());

            Console.Write("Delivery Fee: ");
            decimal fee1 = decimal.Parse(Console.ReadLine());

            Console.Write("City: ");
            string city1 = Console.ReadLine();

            Console.Write("Street: ");
            string street1 = Console.ReadLine();

            Console.Write("Building Number: ");
            int building1 = int.Parse(Console.ReadLine());

            DeliveryAddress address1 = new DeliveryAddress(city1, street1, building1);

            Shipment shipment1 = new Shipment(code1, description1, weight1, fee1, address1);

            if (center.AddShipment(shipment1))
                Console.WriteLine("Shipment added successfully.");

           
            

            // Print Shipments
            Console.WriteLine("\n - All Shipments");

            center[0].PrintShipment();
            Console.WriteLine();

          

            // Search
            Console.Write("\nEnter a tracking code to search: ");
            string searchCode = Console.ReadLine();

            Shipment found = center[searchCode];

            if (!string.IsNullOrEmpty(found.TrackingCode))
            {
                Console.WriteLine($"Shipment found: {found.TrackingCode} - {found.Description}");
            }
            else
            {
                Console.WriteLine("Shipment not found.");
            }

         }
    }
}
