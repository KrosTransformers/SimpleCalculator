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

            bool correctOperation = false;
            int operation = 0;
            while (!correctOperation)
            {
                Console.WriteLine();
                Console.Write("Vaša voľba: ");
                string userInput = Console.ReadLine();

                correctOperation = int.TryParse(userInput, out operation);
            }

            ProcessOperation(operation);

            Console.ReadKey();
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
                    Console.WriteLine("Operation not implemented.");
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
