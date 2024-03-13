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
                                "What is the word for family?\nA) Vin Diesel\nB) Whanau\nC) Whero", // Q3
                                "What is a pit oven called in Te Reo?\nA) Hangi \nB) Iwi\nC) Pango", // Q4
                                "In Maori, what is a book called??\nA) Pukapuka\nB) Tekau\nC) Waka" // Final
                               };

            // Commented out other levels to return to later.

            /*
            string[] lvlMed = { };
            string
            */

            char lvlSelected;
            do
            {
                Console.WriteLine("Please proceed with level desired, input keybind.\nEasy (E, Q5)\nMedium (M, Q9)\nDifficult (T, Q14)");
                lvlSelected = char.Parse(Console.ReadLine());
                if (lvlSelected == 'E')
                {

                }
                else
                {
                    if (lvlSelected == 'M')
                    {
                        
                    }
                    else
                    {
                        if (lvlSelected == 'T')
                        {

                        }
                    }
                }
            } while (true);

        }
    }
}
