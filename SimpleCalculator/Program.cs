using System;

namespace SimpleCalculator
{

    class Program
    {
        public static void Funcion10()
        {
            Console.WriteLine("Zvolili ste si Logaritmus");
            Console.WriteLine("Zadajte cislo, ktore chcete zlogaritmovat");            
            double.TryParse(Console.ReadLine(), out double numberLog);
            Console.WriteLine("Zadajte zaklad ktorym chcete logaritmovat");
            double.TryParse(Console.ReadLine(), out double numberLogBase);
            double result = Math.Log(numberLog, numberLogBase);
            Console.WriteLine($"Vysledok je {result}");
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");
            Console.WriteLine("-----------------");
            Console.WriteLine("Zadajte číslo požadovanej operácie:");
            Console.WriteLine("1.  Sčítanie");
            Console.WriteLine("2.  Odčítanie");
            Console.WriteLine("3.  Násobenie");
            Console.WriteLine("4.  Delenie");
            Console.WriteLine("5.  Celočíselné delenie");
            Console.WriteLine("6.  Zvyšok po delení");
            Console.WriteLine("7.  Mocnina");
            Console.WriteLine("8.  Druhá odmocnina");
            Console.WriteLine("9.  Faktoriál");
            Console.WriteLine("10. Logaritmus");
            Console.WriteLine("11. Prevod stupňov na radiány");
            Console.WriteLine("12. Prevod radiánov na stupne");

            int operation = GetIntegerNumber("Vaša voľba: ");
            ProcessOperation(operation);

            Console.ReadKey();
        }

        /// <summary>
        /// Gets integer number from console input.
        /// </summary>
        /// <param name="prompt">Console prompt for inputting number.</param>
        /// <returns>Number.</returns>
        private static int GetIntegerNumber(string prompt)
        {
            bool correctNumber = false;
            int number = 0;

            while (!correctNumber)
            {
                Console.WriteLine();
                Console.Write(prompt);
                string userInput = Console.ReadLine();

                correctNumber = int.TryParse(userInput, out number);
            }

            return number;
        }


        /// <summary>
        /// Operácia sčítanie
        /// </summary>
        public static void Plus()
        {
            int num1 = GetIntegerNumber("Zadaj číslo1: ");
            int num2 = GetIntegerNumber("Zadaj číslo2: ");
            int num3 = num1 + num2;
            Console.Write($"\nVýsledok je:  {num3}");
        }


        /// <summary>
        /// Process chosen operation.
        /// </summary>
        /// <param name="operation">Operation.</param>
        private static void ProcessOperation(int operation)
        {
            switch (operation)
            {
                case 1:
                    Plus();
                    break;

                case 2:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 3:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 4:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 5:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 6:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 7:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 8:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 9:
                    Console.WriteLine(SolveFactorial(GetIntegerNumber("zadaj cislo")));
                    break;

                case 10:
                    Funcion10();
                    //Console.WriteLine("Operation not implemented.");
                    break;

                case 11:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 12:
                    Operation12();
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }
 
        static int SolveFactorial(int number)
        {
            if (number <= 1)
            {
                return 1;
            }
            return number * SolveFactorial(number - 1);
        }


        private static double CheckDouble()
        {
            //checks if the input is good
            double result;
            while (true)
            {

                
                string input = Console.ReadLine();

                if (double.TryParse(input, out result))
                {
                    
                        return result;
                  
                }
                else
                {
                    Console.WriteLine("Wrong format Try Again");
                }
            }

        }

        private static  void Operation12()
        {
            Console.WriteLine("Enter radian");

            Console.WriteLine($"Degrees:{ (CheckDouble() * (180.0 / Math.PI))}");
            

        }
    }
}