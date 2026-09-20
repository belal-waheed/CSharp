namespace OOP02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region q1
            //a) What is the difference between a class and a struct?
            // class is a reference type, while struct is a value type.
            // Classes support inheritance and polymorphism,while structs do not.
            // Classes are allocated on the heap, while structs are typically allocated on the stack.

            //b) Why are classes more suitable than structs for large applications?
            // Classes are more suitable for large applications because they support inheritance and polymorphism,
            // allowing for more flexible and complex relational designs.
            #endregion


            #region q2
            /*
            public class Shipment
            {
                public string Trackingcode { get;set;}
            }
            public class ExpressShipment: Shipment
            {    
                public decimal ExtraFee { get; set; }
            }
             */
            /*
            a) Which class is the parent class? -> Shipment
            
            b) Which class is the child class? -> ExpressShipment
            
            c) What members are inherited by ExpressShipment? -> Trackingcode
             
            d) Why is inheritance better than duplicating the same code in multiple classes?
            Inheritance allows for code reuse and maintains a clear relationship between classes
            making the code easier to maintain and scalable.

             */
            #endregion

            #region Part 02.5 Delivery Center Management
            Console.WriteLine("Enter Delivery Center Name:");
            string? centerInput = Console.ReadLine();
            string centerName = string.IsNullOrWhiteSpace(centerInput) ? "Cairo Center" : centerInput.Trim();
            DeliveryCenter center = new DeliveryCenter(centerName);

            // a. Standard Shipment
            Console.WriteLine("\n--- Enter Standard Shipment Details ---");
            string stdCode = ReadString("Enter Tracking Code (e.g. SH001): ");
            string stdDesc = ReadString("Enter Description (e.g. Laptop): ");
            decimal stdWeight = ReadDecimal("Enter Weight in KG (> 0): ", allowZero: false);
            decimal stdFee = ReadDecimal("Enter Delivery Fee (> 0): ", allowZero: false);
            Console.WriteLine("Enter Delivery Address:");
            string stdCity = ReadString("  City: ");
            string stdStreet = ReadString("  Street: ");
            int stdBuilding = ReadInt("  Building Number (> 0): ", allowZero: false);
            DeliveryAddress stdAddress = new DeliveryAddress(stdCity, stdStreet, stdBuilding);
            StandardShipment standardShipment = new StandardShipment(stdCode, stdDesc, stdWeight, stdFee, stdAddress);
            if (center.AddShipment(standardShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            // b. Express Shipment
            Console.WriteLine("\n--- Enter Express Shipment Details ---");
            string expCode = ReadString("Enter Tracking Code (e.g. SH002): ");
            string expDesc = ReadString("Enter Description (e.g. Mobile Phone): ");
            decimal expWeight = ReadDecimal("Enter Weight in KG (> 0): ", allowZero: false);
            decimal expFee = ReadDecimal("Enter Delivery Fee (> 0): ", allowZero: false);
            Console.WriteLine("Enter Delivery Address:");
            string expCity = ReadString("  City: ");
            string expStreet = ReadString("  Street: ");
            int expBuilding = ReadInt("  Building Number (> 0): ", allowZero: false);
            decimal expExtraFee = ReadDecimal("Enter Extra Fee (>= 0): ", allowZero: true);
            DeliveryAddress expAddress = new DeliveryAddress(expCity, expStreet, expBuilding);
            ExpressShipment expressShipment = new ExpressShipment(expCode, expDesc, expWeight, expFee, expAddress, expExtraFee);
            if (center.AddShipment(expressShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            // c. International Shipment
            Console.WriteLine("\n--- Enter International Shipment Details ---");
            string intlCode = ReadString("Enter Tracking Code (e.g. SH003): ");
            string intlDesc = ReadString("Enter Description (e.g. Television): ");
            decimal intlWeight = ReadDecimal("Enter Weight in KG (> 0): ", allowZero: false);
            decimal intlFee = ReadDecimal("Enter Delivery Fee (> 0): ", allowZero: false);
            Console.WriteLine("Enter Delivery Address:");
            string intlCity = ReadString("  City: ");
            string intlStreet = ReadString("  Street: ");
            int intlBuilding = ReadInt("  Building Number (> 0): ", allowZero: false);
            string destinationCountry = ReadString("Enter Destination Country: ");
            decimal customsFee = ReadDecimal("Enter Customs Fee (>= 0): ", allowZero: true);
            DeliveryAddress intlAddress = new DeliveryAddress(intlCity, intlStreet, intlBuilding);
            InternationalShipment intlShipment = new InternationalShipment(intlCode, intlDesc, intlWeight, intlFee, intlAddress, destinationCountry, customsFee);
            if (center.AddShipment(intlShipment))
            {
                Console.WriteLine("Shipment Added Successfully.");
            }

            // Print all shipments
            center.PrintAllShipments();

            // Search for a shipment using tracking code indexer
            Console.WriteLine("\nEnter Tracking Code to Search:");
            string searchCode = ReadString();
            Shipment? found = center[searchCode];
            if (found != null)
            {
                Console.WriteLine($"Shipment Found: {found.TrackingCode} - {found.Description}");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            // Remove one shipment using tracking code
            Console.WriteLine("\nEnter Tracking Code to Remove:");
            string codeToRemove = ReadString();
            if (center.RemoveShipment(codeToRemove))
            {
                Console.WriteLine("Shipment Removed Successfully.");
            }
            else
            {
                Console.WriteLine("Shipment Not Found.");
            }

            // Print remaining shipments
            Console.WriteLine("\n========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("========================================");
            center.PrintAllShipments();
            #endregion
        }

        #region Safe Input Helpers
        static string ReadString(string prompt = "")
        {
            while (true)
            {
                if (!string.IsNullOrEmpty(prompt))
                {
                    Console.Write(prompt);
                }
                string? input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input.Trim();
                }
                Console.WriteLine("Invalid input. Value cannot be empty. Please try again.");
            }
        }

        static decimal ReadDecimal(string prompt, bool allowZero = false)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (decimal.TryParse(input, out decimal value))
                {
                    if (allowZero && value >= 0)
                    {
                        return value;
                    }
                    if (!allowZero && value > 0)
                    {
                        return value;
                    }

                    Console.WriteLine(allowZero
                        ? "Invalid input. Value must be greater than or equal to 0."
                        : "Invalid input. Value must be greater than 0.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid decimal number.");
                }
            }
        }

        static int ReadInt(string prompt, bool allowZero = false)
        {
            while (true)
            {
                Console.Write(prompt);
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                {
                    if (allowZero && value >= 0)
                    {
                        return value;
                    }
                    if (!allowZero && value > 0)
                    {
                        return value;
                    }

                    Console.WriteLine(allowZero
                        ? "Invalid input. Value must be greater than or equal to 0."
                        : "Invalid input. Value must be greater than 0.");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
        #endregion
    }
}
