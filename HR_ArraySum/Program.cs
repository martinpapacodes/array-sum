using System;

namespace HR_ArraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            string[] numbersArray = new string[sizeOfArray];

            string[] elementsOfArray = Console.ReadLine().Split(' ');
            int result = 0;
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = elementsOfArray[i];
                result += int.Parse(numbersArray[i]);
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
  
   

    }
}