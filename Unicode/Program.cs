using System;

namespace Unicode
{
    class Program
    {
        static void Main(string[] args)
        {
            String unicodeString =
                "This unicode string has 2 characters outside the " +
                "ASCII range: \n" +
                "Pi (\u03A0), and Sigma (\u03A3).";
            Console.WriteLine("Inserisci un frase");
            string fraseInserita = Console.ReadLine();
            Console.WriteLine("Original string:");
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine(unicodeString);
            Console.WriteLine();
        }
    }
}
