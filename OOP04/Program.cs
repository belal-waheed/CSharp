using OOP03;

namespace OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.1
            //a)  What is Abstraction in Object - Oriented Programming ?
            //Abstraction means hiding the unnecessary implementation details and showing only the important parts of an object.

            //b)  Why is abstraction considered one of the four pillars of OOP?
            //because it helps us reduce complexity. It allows us to focus on what an object does instead of how it does it.

            #endregion

            #region 1.2
            //a)  What is the difference between an Abstract Class and an Interface?
            //  - An abstract class is a base class that can contain fields, properties, constructors, methods, and abstract members.

            //  - An interface mainly defines a contract that a class must follow.
            //It tells us what a class should provide without being the main base class of that object.

            //b)  When would you choose an Interface instead of an Abstract Class?
            //I would choose an interface when I want to define a common behavior that can be implemented by different classes,
            //even if those classes do not belong to the same inheritance hierarchy.

            //c)  Can a class inherit from multiple abstract classes? Can it implement multiple interfaces?
            //No, a class cannot inherit from multiple classes.

            //Yes, a class can implement multiple interfaces.
            #endregion
            #region part02
            Driver driver = new Driver("Ahmed Mohamed");
            DeliveryCenter center = new DeliveryCenter("Delivery Center");
            center.Driver = driver;

            StandardShipment std = new StandardShipment("SH001", "Laptop-hola", 3m, 80m, new DeliveryAddress("Cairo", "Main St", 10));
            ExpressShipment exp = new ExpressShipment("SH002", "Phone-hola", 2m, 60m, new DeliveryAddress("wilez", "Nile St", 5), 30m);
            InternationalShipment intl = new InternationalShipment("SH003", "Television-hola", 8m, 120m, new DeliveryAddress("SAR", "Alexanderplatz", 1), "Germany", 100m);

            center.AddShipment(std);
            center.AddShipment(exp);
            center.AddShipment(intl);

            center.PrintAllShipments();
            Console.WriteLine("Tracking Status");
            ITrackable[] trackables = new ITrackable[] { std, exp, intl };
            foreach (ITrackable t in trackables)
            {
                DeliveryReport.PrintShipment(t);
            }
            Console.WriteLine("====================<-hola->======================");

            // g & i - build an IInsurable[] array and print each shipment's insurance through it
            Console.WriteLine("Insurance");
            IInsurable[] insurables = new IInsurable[] { std, exp, intl };
            foreach (IInsurable ins in insurables)
            {
                DeliveryReport.PrintInsurance(ins);
            }
            Console.WriteLine("====================<-hola->======================");

            Console.WriteLine("done.");
            #endregion
        }
    }
}
