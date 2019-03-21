using System;

namespace SimpleCalculator
{

    class Program
    {

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
        /// Process chosen operation.
        /// </summary>
        /// <param name="operation">Operation.</param>
        private static void ProcessOperation(int operation)
        {
            switch (operation)
            {
                case 1:
                    Console.WriteLine("Operation not implemented.");
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
                    ZvysokPoDeleni();
                    break;

                case 7:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 8:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 9:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 10:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 11:
                    Console.WriteLine("Operation not implemented.");
                    break;

                case 12:
                    Console.WriteLine("Operation not implemented.");
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    break;
            }
        }

    }

}
