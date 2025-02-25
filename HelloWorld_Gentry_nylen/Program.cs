namespace HelloWorld_Gentry_nylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // asks user for first name and adds respronce in string
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            // asks user for middle name and adds respronce in string
            Console.Write("(Optional)Please enter your middle name: ");
            string middleName = Console.ReadLine();

            // asks user for last name and adds respronce in string
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();
        
            // asks user for thier favorite food and adds respronce in string
            Console.Write("What is your favorite food? ");
            string favoriteFood = Console.ReadLine();

            // prints all responces to console
            Console.WriteLine($"Hello {firstName} {middleName} {lastName}, lets go get {favoriteFood} later!");
        }
    }
}
