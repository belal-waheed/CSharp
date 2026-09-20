namespace OOP03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            // a) What is the difference between Method Overloading and Method Overriding?
            // - Overloading: Same method name with different parameters in the same class (compile-time).
            // - Overriding: Redefining a base class virtual method in a derived class using the 'override' keyword (runtime).

            // b) What is the difference between Static Binding and Dynamic Binding?
            // - Static Binding: The method to call is decided at compile time (e.g. normal methods, overloading).
            // - Dynamic Binding: The method to call is decided at runtime based on the actual object type (e.g. virtual/override methods).
            #endregion

            #region Q2
            // a) What is the purpose of the sealed keyword when applied to a class?
            // It prevents other classes from inheriting from it.

            // b) What is the difference between a sealed class and a sealed method?
            // - A sealed class cannot be inherited at all.
            // - A sealed method cannot be overridden anymore in further derived classes.

            // c) Can a sealed method be overridden? Why?
            // No, because the 'sealed' keyword is used specifically to stop further overriding.
            #endregion

            // Driver and Delivery Center
            Driver driver = new Driver("Ahmed Mohamed");
            DeliveryCenter center = new DeliveryCenter("Delivery Center");
            center.Driver = driver;

            // Create Shipments
            StandardShipment std = new StandardShipment("SH001", "Laptop", 3m, 80m, new DeliveryAddress("Cairo", "Main St", 10));
            ExpressShipment exp = new ExpressShipment("SH002", "Mobile Phone", 2m, 60m, new DeliveryAddress("Giza", "Nile St", 5), 30m);
            InternationalShipment intl = new InternationalShipment("SH003", "Television", 8m, 120m, new DeliveryAddress("Berlin", "Alexanderplatz", 1), "Germany", 100m);

            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(intl);

            center.PrintAllShipments();

            Console.WriteLine("\nPrinting Using DeliveryHelper...\n");
            DeliveryHelper.PrintShipmentDetails(std);
            DeliveryHelper.PrintShipmentDetails(exp);
            DeliveryHelper.PrintShipmentDetails(intl);

            Console.WriteLine("\nUpdating Weight...\n");
            Console.WriteLine($"Original Weight : {std.Weight} KG\n");
            std.UpdateWeight(5m);
            Console.WriteLine($"Updated Weight : {std.Weight} KG\n");
            std.UpdateWeight(5m, 0.5m);
            Console.WriteLine($"Updated Weight After Packing : {std.Weight} KG\n");

            // Printing Using Shipment[]
            Console.WriteLine("\nPrinting Using Shipment[]...\n");
            Shipment[] shipments = new Shipment[] { std, exp, intl };
            foreach (Shipment s in shipments)
            {
                s.PrintShipment();
                Console.WriteLine();
            }

            // Sealed class and sealed method
            CompletedShipment completed = new CompletedShipment("SH004", "Office Chair", 12m, 90m, new DeliveryAddress("Alexandria", "Corniche", 20));
            completed.PrintShipment();

            PriorityInternationalShipment priority = new PriorityInternationalShipment("SH005", "Medical Kit", 4m, 150m, new DeliveryAddress("London", "Baker St", 221), "UK", 80m);
            priority.GenerateCustomsReport();
        }
    }
}
