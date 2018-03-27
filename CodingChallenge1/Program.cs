using System;

namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "She sells seashells by the seashore";
            char[] array = input.ToCharArray();

            for (int i = 0; i < (array.Length / 2); i++)
            {
                char temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            string reversedString = "";
            foreach (char character in array)
            {
                reversedString += character;
            }
            Console.WriteLine(reversedString);
            Console.ReadLine();
        }
    }
}
