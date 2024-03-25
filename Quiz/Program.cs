using System.Net.Security;


// Magnus, ac148904

namespace Quiz
{
    internal class Program
    {

        // Hello

        static void Main(string[] args) // main method
        {
            // Storing typed string method inputName in a string variable.
            string nameRead = inputName();
            char selectLevel = LevelSelect();
            
            

            
            Console.WriteLine($"Kia Ora, {nameRead}");
            Console.Clear();


            // Level selecting
            Console.WriteLine(selectLevel);

            // Lists
            // levelQuizLists();
            
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

        // 

        /*
        static String leaderboard() // Create a process which saves users scores and creates leaderboard. (optional, scrapped later)
        {
            var podium = new List<string> {} or ..

            
        }
        */



        static Char LevelSelect() // Level selecting method
        {
            // Variables
            string keybindString;
            char keyBind;

            Console.WriteLine("Please select your quiz' level.\neasy.\t[press e]\nnormal.\t[press n]\nhard.\t[press h]"); // non-case sensitive. Convert input if uppercase to lowercase ascii character variable

            // Console.Clear();

            // input

            // threadsleep (adds delay)

            // isNullorEmpty

            do
            {
                keyBind = Console.ReadLine().ToLower()[0]; // keybind reading.
                keybindString = keyBind + ""; // converts to string as character in dowhile does not have the ability to utilise "isNullOrEmpty"

                // calls method for Questions and Answers.



                switch (keyBind)
                {
                    case 'e':
                        // Easy selected
                        Console.WriteLine("You have selected easy. ");
                        

                       
                        break;
                    case 'n':
                        //Normal selected
                        Console.WriteLine("You have selected normal. ");
                        

                      
                        break;
                    case 'h':
                        //Hard selected
                        Console.WriteLine("You have selected hard. ");
                        
                        
                        
                        break;
                    default:
                        Console.WriteLine("The key input is invalid. Please input the keys provided."); // invalid prompt
                         // clears to prevent stacking of error msg

                        break;
                }
            } while (string.IsNullOrWhiteSpace(keybindString)); // while string is null or whitespace it will continue running the default for the switch.

            return keyBind; // returns key entered.
        }

        /*
        static Int32 scoreRecieved() // This method gives user their score recieved via .. 
        {






            return;
        }
        */

        static String[][] levelQuizLists(string[][] lvlStorage) // This method contains all the questions and answers in lists.
        {

            // easy level consists of 7 questions.

            var easyLvlQuestions = new List<string> { "What is the number one in Te Reo?\nA) Tahi\nB) Kai\nC) Kakariki", // Q1
                            "In Maori, which mean hello and goodbye? (In order)\nA) Kia Ora, Haere Ra\nB) Etu, Enoho\nC) Haere Ra, Ora Kia", // Q2
                            "What is the word for family?\nA) Vin Diesel\nB) Whanau\nC) Whero", // Q3
                            "What is a pit oven called in Te Reo?\nA) Hangi \nB) Iwi\nC) Pango", // Q4
                            "In Maori, what is a book called??\nA) Pukapuka\nB) Tekau\nC) Waka" // Final
                                                                                                };

            // normal level consists of 10 questions.

            var normalLvlQuestions = new List<string> { };

            // hard level consists of 17 questions.


            var hardLvlQuestions = new List<string> { };


            // easy level answers.

            var easyLvlAnswers = new List<string> { };

            // normal level answers.

            var normalLvlAnswers = new List<string> { };

            // hard level answers.

            var hardLvlAnswers = new List<string> { };

            // Lists that store all the text containing the questions and answers

            // return; 

            // no static variables


            // stores lists in array
            

            return lvlStorage;
        }
    }

}

