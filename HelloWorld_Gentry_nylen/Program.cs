namespace HelloWorld_Gentry_nylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("(Optional)Please enter your middle name: ");
            string middleName = Console.ReadLine();


            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.Write("What is your favorite food? ");
            string favoriteFood = Console.ReadLine();


            Console.WriteLine($"Hello {firstName} {middleName} {lastName}, lets go get {favoriteFood} later!");
        }
    }
}
