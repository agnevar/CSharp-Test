using System;

namespace Third
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your word: ");
            var word = Console.ReadLine();

            char[] charArray = word.ToCharArray();
            Array.Reverse(charArray);

            Console.WriteLine("Word in reverse is: " + new string(charArray));
      
        }
    }
}
