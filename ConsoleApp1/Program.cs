namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
        }
        //1. Factorial Calculator function
        static double CalculateFactoria(double number)
        {
            double fact = 1;
            for (double i = 2; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
        //2. Prime Number Checker function
        static bool IsPrime(double number)
        {
            bool is_prime = true;
            if (number <= 1) { is_prime = false; }
            else
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0) { is_prime = false; }
                }
            }

            return is_prime;
        }

        //3. Fibonacci Sequence Generator function
        static List<int> GenerateFibonacci(int num)
        {
            List<int> Fibonacci = new List<int>();
            int n1 = 0, n2 = 1, n3;
            if (num == 0) { Fibonacci.Add(0); }
            else if (num == 1)
            {
                Fibonacci.Add(0);
                Fibonacci.Add(1);
            }
            else
            {
                Fibonacci.Add(0);
                Fibonacci.Add(1);

                for (int i = 2; i <= num; i++)
                {
                    n3 = n1 + n2;
                    Fibonacci.Add(n3);
                    n1 = n2;
                    n2 = n3;
                }
            }
            return Fibonacci;
        }

        //4. Greatest Common Divisor (GCD) function
        static int GCD(int num1, int num2)
        {
            List<int> listNum1 = new List<int>();
            List<int> listNum2 = new List<int>();
            List<int> compine = new List<int>();

            for (int i = 1; i <= num1; i++)
            {
                if (num1 % i == 0) { listNum1.Add(i); }
            }

            for (int i = 1; i <= num2; i++)
            {
                if (num2 % i == 0) { listNum2.Add(i); }
            }

            foreach (int i in listNum1)
            {

                if (listNum2.Contains(i))
                {
                    compine.Add(i);
                }

            }
            return (compine.Max());
        }

        //5.  Sum of Digits function
        static int SumOfDigits(int num)
        {
            int sum = 0, n;
            string StringNum = num.ToString();

            if (num < 0)
            {
                StringNum = StringNum.Substring(1);
                foreach (char c in StringNum)
                {

                    n = c - '0';
                    sum += n;

                }
            }
            else
            {

                foreach (char c in StringNum)
                {

                    n = c - '0';
                    sum += n;

                }
            }

            return sum;
        }

        //6. Array Average function

        static double CalculateAverage(List<int> input_array)
        {
            double total = 0.0;
            foreach (int i in input_array)
            {
                total += i;
            }
            return (total / input_array.Count);
        }


        //7. Count Vowels in a String function

        static int CountVowels(string worldIn)
        {
            int count = 0;
            string vowels = "aioue";
            worldIn.ToLower();

            foreach (char c in worldIn)
            {
                if (vowels.Contains(c)) { count++; }
            }
            return count;
        }


        //8. Temperature Converter function
        static double CelsiusToFahrenheit(double celsius)
        {
            double f = celsius * 9 / 5 + 32;
            return f;
        }

        static double FahrenheitToCelsius(double fahrenheit)
        {
            double c = (fahrenheit - 32) * 9 / 5;
            return c;
        }

        //9. Word Count function
        static int CountWords(string input)
        {
            string[] splitWord = input.Split(' ');
            return splitWord.Length;
        }

        //10.  String Capitalization function

        static string CapitalizeFirstLetter(string input)
        {
            string[] words = input.Split(' ');



            for (int i = 0; i < words.Length; i++)
            {
                words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
            }


            return (string.Join(" ", words));

        }

        //functon to handel invalid input
        static int handelIntError(string input)
        {
            int num;
            if (int.TryParse(input, out num)) { return num; }

            else
            {
                Console.WriteLine("Invalid input");
                return -1;

            }
        }
        static double handelDoubleError(string input)
        {
            double num;
            if (double.TryParse(input, out num)) { return num; }

            else
            {
                Console.WriteLine("Invalid input");
                return -1;
            }
        }



    }
}
