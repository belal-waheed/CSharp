namespace gym
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member member = new Member();

            Console.WriteLine("enter member ID:");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int id) || id <= 0)
                {
                    Console.WriteLine("Please enter a valid integer greater than 0 for member ID:");
                }
                else
                {
                    member.Id = id;
                    break;
                }
            } while (true);

            Console.WriteLine("enter member name:");
            do
            {
                string? name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Please enter a valid name:");
                }
                else
                {
                    member.Name = name;
                    break;
                }
            } while (true);

            Console.WriteLine("enter member age:");
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int age) || age < 16 || age > 50)
                {
                    Console.WriteLine("Please enter a valid age between 16 and 50:");
                }
                else
                {
                    member.Age = age;
                    break;
                }
            } while (true);

            Console.WriteLine("\nChoose Gender:");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            do
            {
                Console.Write("Enter choice (1-2): ");
                if (int.TryParse(Console.ReadLine(), out int genderChoice) && (genderChoice == 1 || genderChoice == 2))
                {
                    member.Gender = (genderChoice == 1) ? Gender.Male : Gender.Female;
                    break;
                }

                Console.WriteLine("Invalid selection. Please choose 1 for Male or 2 for Female.");
            } while (true);

            Console.WriteLine("\nChoose Membership Type:");
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Premium");
            do
            {
                Console.Write("Enter choice (1-2): ");
                if (int.TryParse(Console.ReadLine(), out int typeChoice) && (typeChoice == 1 || typeChoice == 2))
                {
                    if (typeChoice == 1)
                    {
                        member.MembershipType = MembershipType.Standard;
                        member.MembershipPrice = MembershipPrice.Standard;
                    }
                    else
                    {
                        member.MembershipType = MembershipType.Premium;
                        member.MembershipPrice = MembershipPrice.Premium;
                    }
                    break;
                }

                Console.WriteLine("Invalid selection. Please choose 1 for Standard or 2 for Premium.");
            } while (true);
            Console.Clear();
            Console.WriteLine("MEMBER INFORMATION");
            Console.WriteLine($"ID: {member.Id}");
            Console.WriteLine($"Name: {member.Name}");
            Console.WriteLine($"Age: {member.Age}");
            Console.WriteLine($"Gender: {member.Gender}");
            Console.WriteLine($"Membership Type: {member.MembershipType}");
            Console.WriteLine($"Membership Price: {(int)member.MembershipPrice}");
        }
    }
}