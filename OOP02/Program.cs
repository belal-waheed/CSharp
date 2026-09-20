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
        }
    }
}
