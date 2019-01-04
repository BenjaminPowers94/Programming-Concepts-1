/* Program.cs
 * inClass4.
 * 
 * Revision History
 *      Jaehyun Park & Ben Powers, 2018.04.02: Created Project
 */
using System;

namespace InClass4
{
    class Program
    {
        /*******************
         * CONST VARIABLES *
         *******************/

        // Max movie index
        const int MAX_MOVIES = 5;

        // MENU indexes
        const int MENU_BUY_TICKET = 1;
        const int MENU_EXIT = 2;

        // MENU strings
        const string STR_TITLE = "Welcome to our Multiplex Menu";
        const string STR_MENU_1 = "1. Buy a ticket";
        const string STR_MENU_2 = "2. Exit the program";
        const string STR_MENU_BLANK = "";

        /**************************
         * PRIVITE STATIC METHODS *
         **************************/

        // Draw a menu box
        static void DrawMenu()
        {
            Console.Clear();

            Console.WriteLine("");
            Console.WriteLine(STR_TITLE);
            Console.WriteLine("");
            Console.WriteLine(STR_MENU_1);
            Console.WriteLine(STR_MENU_2);
            Console.WriteLine();
        }

        // Set default film names
        static void SetDefaultFilmNames(string[] filmNames)
        {
            filmNames[0] = "A Bad Moms Christmas (15)";
            filmNames[1] = "Blade Runner 2049 (15)";
            filmNames[2] = "Thor: Ragnarok (12A)";
            filmNames[3] = "Murder on the Orient Epress (18)";
            filmNames[4] = "Starwars The Last Jedi (U)";
        }

        // Ask the user to select a menu
        static int SelectMenu()
        {
            int input = 0;

            Console.Write("Choose a number of menu [1-2]: ");
            if (!int.TryParse(Console.ReadLine(), out input))
            {
                return -1;
            }
            return input;
        }

        // Do edit movie names
        static void DoEditName(string[] filmNames)
        {
            for (int i = 0; i < filmNames.Length; i++)
            {
                int displayNumber = i + 1;
                Console.Write("Enter the name of film number " + displayNumber + " : ");
                filmNames[i] = Console.ReadLine();

                // Check validation
                if (filmNames[i].Length < 6)
                {
                    Console.WriteLine("Film name should have at least more than 5 characters");
                    Console.WriteLine("Please, try again");
                    Console.ReadKey();

                    i--;
                    continue;
                }

                // Check if movie name contain a proper age rating
                if (filmNames[i].Contains("(U)") ||
                    filmNames[i].Contains("(12A)") ||
                    filmNames[i].Contains("(15)") ||
                    filmNames[i].Contains("(18)"))
                {
                    Console.WriteLine("\"{0}\" was saved successfully", filmNames[i]);
                }
                else
                {
                    Console.WriteLine("Film name should contain a proper age rating");
                    Console.WriteLine("Please, try again");
                    Console.ReadKey();

                    i--;
                    continue;
                }
            }
        }

        // Edit film List
        static void EditMovieList(string[] filmNames, bool question = false)
        {
            string input;
            bool wrongAnswer = false;

            Console.Clear();
            Console.CursorTop = 1;

            do
            {
                if (question)
                {
                    Console.Write("Do you want to edit movie list? [Yes/No]: ");
                    input = Console.ReadLine();

                    switch (input.ToLower())
                    {
                        case "yes":
                        case "y":
                            DoEditName(filmNames);
                            wrongAnswer = false;
                            break;
                        case "no":
                        case "n":
                            wrongAnswer = false;
                            break;
                        default:
                            wrongAnswer = true;
                            break;
                    }
                }
                else
                {
                    DoEditName(filmNames);
                }
            } while (wrongAnswer);
        }

        // Show film names
        static void ShowMovieList(string[] filmNames)
        {
            Console.Clear();
            Console.CursorTop = 1;

            Console.WriteLine("We are presently showing:");

            for (int i = 0; i < filmNames.Length; i++)
            {
                int displayNumber = i + 1;
                Console.WriteLine(displayNumber + ". " + filmNames[i]);
            }
        }

        // Buy a movie ticket.
        static void BuyTicket(string[] filmNames)
        {
            int index;
            int age;
            string ageRating;
            string trimmedName;
            bool exit;

            do
            {
                exit = true;
                Console.Clear();

                ShowMovieList(filmNames);

                // First, ask the number of the film customer want to see.
                Console.Write("Enter the number of the film you wish to see: ");
                if (!int.TryParse(Console.ReadLine(), out index))
                {
                    Console.Write("Wrong input. Please try again.");
                    Console.ReadKey();
                    continue;
                }

                // Second, ask an age of customer.
                Console.Write("Enter your age: ");
                if (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Wrong input. Please try again.");
                    Console.ReadKey();
                    continue;
                }

                // Finally, we got the movie index and age successfully.
                trimmedName = filmNames[index - 1].Trim();
                ageRating = trimmedName.Substring(trimmedName.LastIndexOf('('));

                // Check age rating.
                if (age >= 0 && age < 12) // U
                {
                    switch (ageRating)
                    {
                        case "(U)":
                            Console.Write("\tThanks, Enjoy the movie.");
                            break;
                        case "(12A)":
                        case "(15)":
                        case "(18)":
                            Console.Write("\tAccess denied - you are too yound");
                            break;
                        default:
                            Console.Write("Wrong input. Please try again.");
                            exit = false;
                            break;
                    }

                    Console.ReadKey();
                }
                else if (age >= 12 && age < 15) // 12A
                {
                    switch (ageRating)
                    {
                        case "(U)":
                        case "(12A)":
                            Console.Write("\tThanks, Enjoy the movie.");
                            break;
                        case "(15)":
                        case "(18)":
                            Console.Write("\tAccess denied - you are too yound");
                            break;
                        default:
                            Console.Write("Wrong input. Please try again.");
                            exit = false;
                            break;
                    }

                    Console.ReadKey();
                }
                else if (age >= 15 && age < 18) // 15
                {
                    switch (ageRating)
                    {
                        case "(U)":
                        case "(12A)":
                        case "(15)":
                            Console.Write("\tThanks, Enjoy the movie.");
                            break;
                        case "(18)":
                            Console.Write("\tAccess denied - you are too yound");
                            break;
                        default:
                            Console.Write("Wrong input. Please try again.");
                            exit = false;
                            break;
                    }

                    Console.ReadKey();
                }
                else if (age >= 18) // 18
                {
                    switch (ageRating)
                    {
                        case "(U)":
                        case "(12A)":
                        case "(15)":
                        case "(18)":
                            Console.Write("\tThanks, Enjoy the movie.");
                            break;
                        default:
                            Console.Write("\tWrong input. Please try again.");
                            exit = false;
                            break;
                    }

                    Console.ReadKey();
                }
            } while (!exit);

        }

        // Exit the program
        static bool ExitProgram()
        {
            string inputStr;
            bool exit = false;

            Console.Write("Do you want to exit the program? [Yes/No]: ");
            inputStr = Console.ReadLine();
            switch (inputStr.ToLower())
            {
                case "yes":
                case "y":
                    exit = true;
                    break;
                case "no":
                case "n":
                    exit = false;
                    break;
                default:
                    Console.Write("Wrong input. Please try again.");
                    Console.ReadKey();
                    return false;
            }

            return exit;
        }

        static void Main(string[] args)
        {
            int input = 0;      // a menu selected by user  
            bool exit = false;  // program exit flag
            string[] filmNames = new string[MAX_MOVIES];    // String array for movie names

            /* Set default film names */
            SetDefaultFilmNames(filmNames);

            // First, we ask to edit the film names
            EditMovieList(filmNames, question: true);

            do
            {
                /* Draw a Menu Box */
                DrawMenu();

                /* Ask the user to select a menu */
                input = SelectMenu();

                switch (input)
                {
                    case MENU_BUY_TICKET:
                        BuyTicket(filmNames);
                        break;
                    case MENU_EXIT:
                        exit = ExitProgram();
                        break;
                    default:
                        Console.Write("Wrong input. Please try again.");
                        Console.ReadKey();
                        break;
                }
            } while (!exit);
        }
    }
}
