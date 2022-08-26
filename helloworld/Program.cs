namespace hellowworld_2
{
    internal class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string stg = "Hello world! (2)";
            Console.WriteLine(stg);

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter users age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Username is: " +username + " and the age is: " + age);
        }
    }
}