using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert text: ");
            var word = Console.ReadLine();
            var firstLetter = word[0];

            var newWord = firstLetter + word + firstLetter;

            Console.WriteLine(newWord);

        }
    }
}
