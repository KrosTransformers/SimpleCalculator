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


        public static void ZvysokPoDeleni()
        {
            Console.WriteLine("zadaj cislo");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("zadaj druhe cislo");
            double b = double.Parse(Console.ReadLine());
            double c = a % b;
            Console.WriteLine("Zvysok po deleni je:/n" + c);

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
                    Operacia3();
                    break;

                case 4:
                    Console.WriteLine("You choose operation devide");              
                    double a = GetIntegerNumber("Type number to devide: ");
                    double b = GetIntegerNumber("Type number by which to devide");
                    Devide(a, b);
                    break;

                case 5:
                    CelociselneDelenie();            
                    break;

                case 6: 
                    ZvysokPoDeleni();
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



        private static void Operacia3()
        {            
            int a = GetIntegerNumber("First number: ");
            int b = GetIntegerNumber("Second number: ");
            Console.WriteLine(a * b);
        }


        private static void Devide(double a, double b)
        {
            if (b > 0) { Console.WriteLine(@"Result: " + a / b); }
            else { Console.WriteLine("Devided by zero"); }
            
        }


        private static void CelociselneDelenie()
        {
            int a = GetIntegerNumber("Zadaj prve cislo: ");
            int b = GetIntegerNumber("Zadaj druhe cislo: ");
            if (b != 0)
            {
                int vysledok = a / b;
                Console.WriteLine($"Vysledok: {vysledok}");
            }
            else
            {
                Console.WriteLine("Nulou sa neda delit");
            }
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