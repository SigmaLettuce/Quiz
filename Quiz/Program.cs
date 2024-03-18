namespace Quiz
{
    internal class Program
    {

        // Hello

        static void Main(string[] args) // main method
        {
            // Storing typed string method inputName in a string variable.
            string nameRead = inputName();
            string selectLevel = LevelSelect();

            Console.Clear();
            Console.WriteLine($"Kia Ora, {nameRead}");

            // Level selecting
            Console.WriteLine(selectLevel);
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

        static String LevelSelect()
        {
            char keyBind;
            Console.WriteLine("Please select your quiz' level.\neasy.\t[press e]\nnormal.\t[press n]\nhard.\t[press h]"); // non-case sensitive. Convert input if uppercase to lowercase ascii character variable

            // Console.Clear();

            // input

            // isNullorEmpty

            do
            {
                keyBind = Console.ReadLine().ToLower()[0]; // keybind

                string easySelected = easyLevel();
                string normalSelected = normalLevel();
                string hardSelected = hardLevel();

                switch (keyBind)
                {
                    case 'e':
                        Console.Clear();
                    break;
                    case 'n':
                        Console.Clear();
                    break;
                    case 'h':
                        Console.Clear();
                    break;
                    default:
                        Console.WriteLine("The key input is invalid. Please input the keys provided."); // invalid prompt
                        Console.Clear(); // clears to prevent stacking of error msg
                    break;
                }
            } while (keyBind.);

            return 
        }

        static Int32 scoreRecieved() // This method gives user their score recieved via .. 
        {
            /*
            
            
             
            */


        }

        static String easyLevel() // easy levels typed method consists of 7 questions.
        {
            
        }

        static String normalLevel() // normal levels typed method consists of 10 questions.
        {

        }

        static String hardLevel() // hard levels typed method consists of 17 questions.
        {

        }
        

        // switch. used for keybind input

      


    // Username stuff end




}
}
