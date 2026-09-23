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
        }
    }
}
