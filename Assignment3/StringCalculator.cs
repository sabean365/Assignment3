using System;
using System.Linq;


namespace Calculator
{
    public class StringCalculator
    {

        public int Add(string numbers)
        {

            if (numbers.Length == 0)
                return 0;

            int[] numbersArray = numbers.Split(',').Select(n => int.Parse(n)).ToArray();

            CheckForNegative_ThrowException(numbersArray);

            if (numbers.Length == 1)
                return Int32.Parse(numbers);

            if (numbersArray.Any(n => n > 1000))
                return numbersArray.Where(n => n <= 1000).Sum(n => n);

            if (numbers.Length >= 3)
            {
                int sum = 0;
                //Did a for loop here because you were asking for one in the help video
                //Could have: return numbersArray.Sum(n => n)
                for (int i = 0; i < numbersArray.Length; i++)
                {
                    sum += numbersArray[i];
                }
                return sum;
            }



            return -1;
        }
        private static void CheckForNegative_ThrowException(int[] numbersArray)
        {
            if (numbersArray.Any(n => n < 0))
                throw new Exception($"Negatives not allowed: {string.Join(" ", numbersArray.Where(n => n < 0))}");
        }




    }
}
