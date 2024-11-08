using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ZadanieNaOcene
{
    internal class Program
    {

        static int[] PossiblePoints = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 2, 3, 4, 11 };
        static int PlayerScore = 0;
        static int ComputerScore = 0;
        static bool GameStatus = true;
        static bool ProgramStatus = true;

        private static Random random = new Random();

        
        static void DisplayMainMenu()
        {
            Console.WriteLine("Witaj w grze oczko!");
            Console.WriteLine("Wybierz co chcesz zrobić:");
            Console.WriteLine("1. Rozpocznij nową grę");
            Console.WriteLine("2. Wyjdź z programu");
            Console.WriteLine("Wpisz 1 lub 2 i zatwierdź wybór przyciskiem ENTER");
        }

        static void DisplayGameMenu()
        {
            Console.WriteLine("1. Dobierz kartę");
            Console.WriteLine("2. Sprawdź wynik komputera");
        }

        static void DisplayPlayerScore()
        {
            Console.WriteLine($"Twój wynik to {PlayerScore}");
        }

        static void DisplayComputerScore()
        {
            Console.WriteLine($"Wynik komputera to {ComputerScore}");
        }

        static void TakeCard()
        {
            PlayerScore = PlayerScore + PossiblePoints[random.Next(PossiblePoints.Length)];
            ComputerScore = ComputerScore + PossiblePoints[random.Next(PossiblePoints.Length)];
        }

        static void CheckScores()
        {
            if (PlayerScore > 21)
            {
                Console.WriteLine();
                DisplayPlayerScore();
                Console.WriteLine("Twój wynik przekracza 21. Przegrałeś.");
                //DisplayComputerScore();
                //DisplayPlayerScore();
                Console.WriteLine("Wciśnij ENTER aby przejść do menu głównego");
                Console.ReadLine();
                GameStatus = false;
                
            }
            else if (PlayerScore == 21)
            {
                Console.WriteLine("Trafiłeś 21. Wygrałeś!");
                Console.WriteLine("Wciśnij ENTER aby przejść do menu głównego");
                Console.ReadLine();
                GameStatus = false;
            }
            else if (ComputerScore == 21 && PlayerScore == 21)
            {
                Console.WriteLine("Wynik twój i komputera to 21. Remis!");
                Console.WriteLine("Wciśnij ENTER aby przejść do menu głównego");
                Console.ReadLine();
                GameStatus = false;
            }
        }

        static void CompareScores()
        {
            if (PlayerScore < ComputerScore && ComputerScore < 21) { Console.WriteLine("Przegrałeś!"); }
            else if (PlayerScore == ComputerScore) { Console.WriteLine("Wow! Remis!"); }
            else  { Console.WriteLine("Wygrałeś!"); }
            Console.ReadLine();
            GameStatus = false;
        }

        static void ResetGameAndScores()
        { 
            GameStatus = true;
            PlayerScore = 0;
            ComputerScore = 0;
        }


        static void Main(string[] args)
        {
            while (ProgramStatus)
            {
                Console.Clear();
                ResetGameAndScores();
                DisplayMainMenu();
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        while (GameStatus)
                        {

                            Console.Clear();
                            DisplayPlayerScore();
                            DisplayGameMenu();
                            input = Console.ReadLine();
                            switch (input)
                            {
                                case "1":
                                    TakeCard();
                                    CheckScores();
                                    break;
                                case "2":
                                    DisplayComputerScore();
                                    CompareScores();
                                    break;
                                default:
                                    Console.WriteLine("Nieprawidłowy input. Wciśnij ENTER i spróbuj ponownie");
                                    Console.ReadLine();
                                    break;
                            }

                        }
                        break;
                    case "2":
                        Console.WriteLine("Kliknij ENTER aby potwierdzić zamknięcie programu");
                        Console.Read();
                        ProgramStatus = false;  
                        break;
                    default:
                        Console.WriteLine("Nieprawidłowy input. Wciśnij ENTER i spróbuj ponownie");
                        Console.ReadLine();
                        break;

                }
            }
        }
    }
}
