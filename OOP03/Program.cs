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
            // - Dynamic Binding: The method to call is decided at runtime based on the actual object type ( virtual/override methods).
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
        }
    }
}
