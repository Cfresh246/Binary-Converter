using System.Text;

namespace Binary_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Enter a number: ");
            string? number = Console.ReadLine().Replace(" ", "");

            BinaryToDecimal(number);
        }
        static void BinaryToDecimal(string n)
        {
            double total = 0;
            int index = n.Length - 1;

            for (int i = 0; i < n.Length; i++)
            {
                
                total += int.Parse(n[i].ToString()) * Math.Pow(2, index);
                index--;
            }
            Console.WriteLine(total);
        }
    }
}
 