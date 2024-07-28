using System;

class Program 
{
  public static void Main (string[] args) 
  {
    while (true)
                {
                    DisplayMenu();

                    string choice = Console.ReadLine().Trim();
                    if (choice == "1")
                    {
                        CalculateRevenue();
                    }
                    else if (choice == "2")
                    {
                        Console.WriteLine("\nThank you for using the Greenville Revenue App, good-bye!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please select 1 or 2.");
                    }
                }
            }

            static void DisplayMenu()
            {
                Console.WriteLine("\n************************************");
                Console.WriteLine("*  The stars shine in Greenville.  *");
                Console.WriteLine("************************************");
                Console.WriteLine("\nPlease Enter the following number below from the following menu:");
                Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
                Console.WriteLine("2. Exit");
            }

            static void CalculateRevenue()
            {
                try
                {
                    Console.Write("Enter the number of contestants last year: ");
                    int lastYearContestants = int.Parse(Console.ReadLine().Trim());

                    Console.Write("Enter the number of contestants this year: ");
                    int thisYearContestants = int.Parse(Console.ReadLine().Trim());

                    int revenue = thisYearContestants * 25;

                    Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants");
                    Console.WriteLine($"Revenue expected this year is ${revenue}");

                    if (thisYearContestants > lastYearContestants * 2)
                    {
                        Console.WriteLine("The competition is more than twice as big this year!");
                    }
                    else if (thisYearContestants > lastYearContestants)
                    {
                        Console.WriteLine("The competition is bigger than ever!");
                    }
                    else
                    {
                        Console.WriteLine("A tighter race this year! Come out and cast your vote!");
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numeric values for the number of contestants.");
                }
            }
        }