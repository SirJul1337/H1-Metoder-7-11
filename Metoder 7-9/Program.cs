using System;

namespace Metoder_7_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 12;
            int number2 = 3;
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
            Console.WriteLine("Guess the number");
            int guess = int.Parse(Console.ReadLine());
            string userResult = UserGuess(randomNumber, guess);
            Console.WriteLine(userResult);



            int addNumbersResult = AddNumbers(3, 4);
            Console.WriteLine(addNumbersResult);

            float devideVarNumbers = DevideVarNumbers(number1, number2);
            Console.WriteLine(devideVarNumbers);

            int num2UpInNum1 = Num2UpInNum1(number1, number2);
            Console.WriteLine("Number 2 goes up in Number 1 "+num2UpInNum1+" times");
            
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
        public static string UserGuess(int randomNumber, int guess)
        {
            string output = "";
            int guessCount = 0;
            Console.Clear();
            while (true)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess was too high");
                    guessCount++;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess was too low");
                    guessCount++; 
                }
                else if ( guess == randomNumber)
                {
                    guessCount++;
                    if (guessCount <= 5)
                    {
                        guessCount++;
                        output = "You guessed in "+ guessCount+ " good job";
                    }
                    else
                    {
                        guessCount++;
                        output = "You guessed in " + guessCount + " Could be better";
                    }
                    break;
                }
                guess = int.Parse(Console.ReadLine());


            }
                return output;
        }

        #endregion
        #region Opgave 11

        public static int AddNumbers(int number1, int number2)
        {
            return number1 + number2;
        }
        public static float DevideVarNumbers(int number1, int number2)
        {
            return (float)number1 / number2; 
        }
        public static int Num2UpInNum1(int number1, int number2)
        {
            return number1 / number2;
        }
        #endregion
    }
}
