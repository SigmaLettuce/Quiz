namespace Quiz
{
    internal class Program
    {

        // Hello

        static void Main(string[] args) // main method
        {
            // Storing typed string method inputName in a string variable.
            string nameRead = inputName();
            Console.Clear();
            Console.WriteLine($"Kia Ora, {nameRead}");
            
            
        }
        static String inputName() // method reads the name entered and is stored in the variable "nameRead"
        {
            // string variable used to store the entered value for name.
            string nameEntered;
            Console.WriteLine("Proceed with your name, please :");

            // input 
            nameEntered = Console.ReadLine();
            return nameEntered;
        }

        /*
        static String leaderboard() // Create a process which saves users scores and creates leaderboard. (optional, scrapped later)
        {
            var podium = new List<string> {} or ..
        }
        */

        static Int32 scoreRecieved() // This method gives user their score recieved via .. 
        {
            
        }

        

        // Username stuff end

        /* static String levelHierachy()
        {
            // Level Easy

            string[] lvlEasy = {"What is the number one in Te Reo?\nA) Tahi\nB) Kai\nC) Kakariki", // Q1
                                "In Maori, which mean hello and goodbye? (In order)\nA) Kia Ora, Haere Ra\nB) Etu, Enoho\nC) Haere Ra, Ora Kia", // Q2
                                "What is the word for family?\nA) Vin Diesel\nB) Whanau\nC) Whero", // Q3
                                "What is a pit oven called in Te Reo?\nA) Hangi \nB) Iwi\nC) Pango", // Q4
                                "In Maori, what is a book called??\nA) Pukapuka\nB) Tekau\nC) Waka" // Final
                               };



            // Commented out other levels to return to later.

            /*
            string[] lvlMed = {""};
            string[] lvlDiff = { };
            */

            
        /*

            char lvlSelected;
            
            do
            {
                Console.WriteLine("Please proceed with level desired, input keybind.\nEasy (E, Q5)\nMedium (M, Q9)\nDifficult (T, Q14)"); // Chose T (why not)
                lvlSelected = Console.ReadLine().ToUpper()[0];

            } while ();

            //end do

        }
        

        // Commented out if statement. Using switches. Not deleted to review.

        /*
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

 */


    }
}
