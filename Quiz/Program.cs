namespace Quiz
{
    internal class Program
    {

        // Hello

        static void Main(string[] args)
        {
            string nameRead = inputName();
            Console.Clear();
            Console.WriteLine($"Welcome, {nameRead}");
        }
        static String inputName()
        {
            string nameEntered;
            Console.WriteLine("Proceed with your name, please:");
            nameEntered = Console.ReadLine();
            return nameEntered;
        }

        static String levelHierachy()
        {
            string[] lvlEasy = { };
        }
    }
}
