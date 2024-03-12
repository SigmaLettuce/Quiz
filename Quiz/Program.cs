namespace Quiz
{
    internal class Program
    {

        // Hello

        static void Main(string[] args)
        {
            // Storing typed string method inputName in a string variable.
            string nameRead = inputName();
            Console.Clear();
            Console.WriteLine($"Welcome, {nameRead}");
        }
        static String inputName()
        {
            // string variable used to store the entered value for name.
            string nameEntered;
            Console.WriteLine("Proceed with your name, please :");

            // input 
            nameEntered = Console.ReadLine();
            return nameEntered;
        }

        static String levelHierachy()
        {
            string[] lvlEasy = {"What is the number one in Te Reo?\nA) Tahi\nB) Kai\nC) Kakariki", // Q1
                                "In Maori, which mean hello and goodbye? (In order)\nA) Kia Ora, Haere Ra\nB) Etu, Enoho\nC) Haere Ra, Ora Kia", // Q2
                                "What is the word for family?\nA) Vin Diesel\nB) Whanau\nC) Whero" // Q3
                               };

        }
    }
}
