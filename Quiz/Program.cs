using System.Net.Security;


// Magnus, ac148904

namespace Quiz
{
    internal class Program
    {

        // Hello
        // arrray legnth
        static void Main(string[] args) // main method
        {
            // Storing typed string method inputName in a string variable.
            string nameRead = inputName();
            String[][] lvlQuiz = levelQuizLists();

            Console.WriteLine($"Kia Ora, {nameRead}");
            Thread.Sleep(700); // adds delay to the clearing of the console to allow level selection method to be called on a blank console.
            Console.Clear();

            LevelSelect();

            // Level selecting
            // Console.WriteLine(selectLevel);

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



        static string LevelSelect() // Level selecting method
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
            } while (string.IsNullOrEmpty(keybindString)); // while string is null or empty it will continue running the default for the switch.

            return keybindString; // returns key entered.
        }

       

         static String EasySelected()
        {
            String[][] QuestionArray = levelQuizLists();
            Char[] QuestionSelect = { 'A','B','C'};
            char input;
            int passingMark = 0;

            for (int i = 0; i < QuestionArray.Length; i++) // array 1 is selected and question 1 in array 1 is selected.
            {
                Console.WriteLine(QuestionArray);
            }

            return
        }

        /*
        static String NormalSelected()
        {

            return
        }

         static String HardSelected()
        {

            return
        }

        */

        //if keybind[i]

        /*
        static Int32 scoreRecieved() // This method gives user their score recieved via .. 
        {






            return;
        }
        */

        static String[][] levelQuizLists() // This method contains all the questions and answers in arrays, then stores the arrays in another array.
        {

            // I am using a jagged array to purpose a specific method to store my questiions and answers instead of taking up space in the methods for the level difficulties.

            // easy level consists of 7 questions.

            String[] easyLvlQuestions = { "What is the number one in Te Reo?\nA) Tahi\nB) Kai\nC) Kakariki", // Q1
                            "In Maori, which mean hello and goodbye? (In order)\nA) Kia Ora, Haere Ra\nB) Etu, Enoho\nC) Haere Ra, Ora Kia", // Q2
                            "What is the word for family?\nA) Vin Diesel\nB) Whanau\nC) Whero", // Q3
                            "What is a pit oven called in Te Reo?\nA) Hangi \nB) Iwi\nC) Pango", // Q4
                            "In Maori, what is a book called??\nA) Pukapuka\nB) Tekau\nC) Waka" // Final
                                                                                                };

            // normal level consists of 10 questions.

            String[] normalLvlQuestions = { "When was Tiriti o Waitangi signed by the Monarch and Maori chiefs?\nA) 1776\nB) 1840\nC) 20 BC", // Q1
            "What is the name of the Maori New Year?\nA) Tangata whenua\nB) Matariki\nC) Whero", // Q2
            "Which action began the Flagstaff War?\nA) The creation of the New Zealand flag, becoming controversial between British and Maori figures of history\nB) The creation of the American flag in July 4th, 1960\nC) Hone Heke chopping down the flagstaff in Kororareka", // Q3
            "When did the Flagstaff War begin?\nA) 11 Mar 1845\nB) 12 Mar 1845\nC) 14 Mar 1845", // Q4
            "How old is Hone Heke?\nA) 43\nB) 20\nC) He is dead", // Q5
            "What was the problem with the Tiriti which begun the outbreak of war?\nA) Error in translation\nB) ",
            }; 

            // hard level consists of 17 questions.

            String[] hardLvlQuestions = { "" };

            // easy level answers.

            String[] easyLvlAnswers = { "A", "A", "B", "A", "A" };

            // normal level answers.

            String[] normalLvlAnswers = { };

            // hard level answers.

            String[] hardLvlAnswers = { };

            // Lists that store all the text containing the questions and answers

            // return; 

            // no static variables


            // stores lists in array

            String[][] quizListArray = {easyLvlQuestions, easyLvlAnswers, normalLvlQuestions, normalLvlAnswers, hardLvlQuestions, hardLvlAnswers}; // final array
            // array of arrays require double square brackets such as [][]. the first bracket contains which array is selected and the second bracket contains which in that array is selected.
            return quizListArray;
        }
    }

}

