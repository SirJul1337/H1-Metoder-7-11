using System;

namespace Metoder_7_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int indexId = 5;
            int arrayResult = ArrayFind(indexId);
            Console.WriteLine(arrayResult);

            Console.WriteLine("LOTTO");
            int [] lottoNumbers = LottoNumbers();
            int[] userNumbers = UserNumbers();
            int correctNumber = CheckNumber(userNumbers, lottoNumbers);
            string prizeResult = Prize(correctNumber);
            Console.WriteLine("You got "+ correctNumber+" Numbers correct");
            Console.WriteLine(prizeResult);
            int randomNumber = SecretNumber();
            //User guess
            int userResult = UserGuess(randomNumber);
            
        }
        #region Array - double index 5
        public static int ArrayFind(int IndexId)
        {
            int[] Array1 = new int[9];
            for (int i = 0; i < 9; i++)
            {
                Array1[i] = i+1;
                if (i == IndexId)
                {
                    Array1[i] = Array1[i] * 2;
                }
            }
            return Array1[IndexId];
        }
        #endregion
        #region Lotto
        public static int [] LottoNumbers()
        {
            int [] output = new int[7];
            Random random = new Random();
            int [] LottoNumbers = new int[7];
            for (int i = 0;i < 7; i++)
            {
                LottoNumbers[i] = random.Next(1, 20);
                output[i] += LottoNumbers[i];
            }
            return output;

        }
        public static int[] UserNumbers()
        {
            int [] output = new int[7];
            int[] UserNumbers = new int[7];
            for(int i = 0; i<7; i++)
            {
                Console.WriteLine("Write your number "+(i+1));
                UserNumbers[i] = int.Parse(Console.ReadLine());
            }
            return UserNumbers;
        }

        public static int CheckNumber(int [] userNumbers, int [] lottoNumbers)
        {
            int correctNumber = 0;
            for (int i = 0; i < userNumbers.Length; i++)
            {
                for (int j = 0; j < lottoNumbers.Length; j++)
                {
                    if (lottoNumbers[i] == userNumbers[j])
                    {
                        correctNumber++;

                    }
                }

            }
            return correctNumber;
        }
        public static string Prize(int correctNumber)
        {
            int [] prizeMoney = new int [] { 0, 500, 1000, 5000, 20000, 100000, 750000 };
            string output = "";
            output = "You won " + prizeMoney[correctNumber] + " Dollars";
            
            return output;
        }
        #endregion
        #region Guess a number
        public static int SecretNumber()
        {
            Random r = new Random();
            int randomNumber = r.Next(1,100); 
            return randomNumber;
        }
        public static string UserGuess(int randomNumber)
        {
            string output = "";
            int guessCount = 0;
            while (true)
            {
                if (randomNumber > 0)
                {

                    guessCount++;
                }
                else if (randomNumber < 0)
                {
                    guessCount++;
                }
                else if (randomNumber == 0)
                {
                    guessCount++;
                    if (guessCount >= 5)
                    {
                        guessCount++;
                        output = "You guessed in "+ guessCount+ " good job";
                    }
                    else
                    {
                        guessCount++;
                        output = "You guessed in " + guessCount + " Could be better";
                    }
                }
                //ReadLine Guess inpu

            }
                return output;
        }

        #endregion
    }
}
