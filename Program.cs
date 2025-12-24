using System.Text;

namespace Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            BinaryToDecimal();
        }
        static void BinaryToDecimal()
        {
            string number = ReadBinary();

            double total = 0;
            int index = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                
                total += int.Parse(number[i].ToString()) * Math.Pow(2, index);
                index--;
            }
            Console.WriteLine(total);
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
    }
}
 