using static System.Net.Mime.MediaTypeNames;

namespace eigenes_Projekt_1
{
    internal class Program
    {
        //coordinate places
        static char[] places = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe v0.00002");

            bool breakLoop = false;


            bool symbolChosen = false;



            string Menu = "";

            char Symbol = '0';

            string stringCoord;
            char coord = 'x';

            bool X;
            bool O;



            //menu - start, choose, close
            while (breakLoop == false)
            {
                Menu = Console.ReadLine();
                switch (Menu)
                {
                    //choosing symbol
                    case "choose":
                        Console.WriteLine("X or O");
                        while (symbolChosen == false) 
                        {
                            try
                            {
                                string str = Console.ReadLine();
                                if (str == "close")  
                                {
                                    Environment.Exit(0);
                                }
                                Symbol = char.Parse(str);

                                X = Symbol.Equals('X') || Symbol.Equals('x');
                                O = Symbol.Equals('O') || Symbol.Equals('o');

                                if (X == false && O == false)
                                {
                                    throw new Exception("user used anything but O or X");
                                }
                                symbolChosen = true;
                                Console.SetCursorPosition(0, Console.CursorTop - 1);
                                Console.WriteLine(Symbol + ". cool.");
                            }
                            catch
                            {
                                Console.WriteLine("failed to convert/input is not x or o");
                            }
                        }
                        break;

                    //starting game
                    case "start":
                        if(symbolChosen == true)
                        {
                            breakLoop = true;
                        }
                        else
                        {
                            Console.WriteLine("choose your symbol first");
                        }
                        break;


                    //close game
                    case "close":
                        Environment.Exit(0);
                        break;

                    //invalid input
                    default:
                        Console.WriteLine("choose   start   close");
                        break;
                }
            }

            //symbol chosen + game started
            Console.Clear();
            Board();

            while (true)
            {
                Console.Write("Coord: ");
                try
                {
                    stringCoord = Console.ReadLine();
                    coord = char.Parse(stringCoord);
                }
                catch
                { 
                    Console.WriteLine("failed to convert coord input");
                }


                switch (coord)
                {
                    case '1':
                        Console.Clear();
                        places[0] = Symbol;
                        break;

                    case '2':
                        Console.Clear();
                        places[1] = Symbol;
                        break;

                    case '3':
                        Console.Clear();
                        places[2] = Symbol;
                        break;

                    case '4':
                        Console.Clear();
                        places[3] = Symbol;
                        break;

                    case '5':
                        Console.Clear();
                        places[4] = Symbol;
                        break;

                    case '6':
                        Console.Clear();
                        places[5] = Symbol;
                        break;

                    case '7':
                        Console.Clear();
                        places[6] = Symbol;
                        break;

                    case '8':
                        Console.Clear();
                        places[7] = Symbol;
                        break;

                    case '9':
                        Console.Clear();
                        places[8] = Symbol;
                        break;

                    default:
                        Console.WriteLine("vaild number please");
                        return;


                }

                Board();
            }

        }
        static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", places[0], places[1], places[2] );
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", places[3], places[4], places[5]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", places[6], places[7], places[8] );
            Console.WriteLine("     |     |      ");
        }
    }
}