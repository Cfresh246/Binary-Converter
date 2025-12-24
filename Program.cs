using System.Text;

namespace Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            MainMenu();
        }
        static void BinaryToDecimal()
        {
            Console.Clear();
            Console.WriteLine("===== Binary To Decimal =====");

            string number = ReadBinary();

            double total = 0;
            int index = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                
                total += int.Parse(number[i].ToString()) * Math.Pow(2, index);
                index--;
            }
            Console.WriteLine(total + "₂");
            Console.Write("Press any key to continue..."); Console.ReadKey();
        }
        static void DecimalToBinary()
        {
            Console.Clear();
            Console.WriteLine("===== Decimal to Binary =====");

            int number = ReadDecimal();

            string binaryNumber = "";

            do
            {
                binaryNumber += number % 2;
                number /= 2;
            } while (number > 0);

            string reverseNumber = "";
            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                reverseNumber += binaryNumber[i];
            }

            Console.WriteLine(reverseNumber + "₁₀");
            Console.Write("Press any key to continue..."); Console.ReadKey();
        }
        static string ReadBinary()
        {
            while (true)
            {
                Console.Write("Enter a number: ");
                string? number = Console.ReadLine().Replace(" ", "");

                bool IsValid = true;

                foreach(char c in number)
                {
                    if (!char.IsDigit(c) || (c != '0' && c != '1'))
                    {
                        IsValid = false; 
                    }
                }

                if (IsValid)
                {
                    return number;
                }
            }
        }
        static int ReadDecimal()
        {
            while (true)
            {
                Console.Write("Enter a binary number: ");
                string? number = Console.ReadLine().Replace(" ", "");

                if (!int.TryParse(number, out int result))
                {
                    Console.WriteLine("Error: Please enter a valid decimal number.");
                    Console.Write("Press any key to continue..."); Console.ReadKey();
                }

                return result;
            }
        }
        static void MainMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=======================");
                Console.WriteLine("    BINARY CONVERTER   ");
                Console.WriteLine("=======================");
                Console.WriteLine("1. Binary to Decimal");
                Console.WriteLine("2. Decimal to Binary");
                Console.WriteLine("3. Quit");
                Console.WriteLine("=======================");

                Console.Write("Choose an option: ");
                string? optionInput = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(optionInput) || !int.TryParse(optionInput, out int option) || (option < 1 || option > 3) )
                {
                    Console.WriteLine("Error: Invalid input.");
                    Console.Write("Press any key to continue..."); Console.ReadKey(); continue;
                }

                if (option == 3)
                {
                    Console.WriteLine("Goodbye!!!"); break;
                }

                switch (option)
                {
                    case 1: BinaryToDecimal(); break;
                    case 2: DecimalToBinary(); break;
                }
            }
        }
    }
}
 