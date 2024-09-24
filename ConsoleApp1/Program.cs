namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int Menuchoice, ContnueChoise;
            while (flag == true)
            {
                Console.Clear();
                Console.WriteLine("choose a number: ");
                Console.WriteLine(" 1. Factorial Calculator  ");
                Console.WriteLine(" 2. Prime Number Checker  ");
                Console.WriteLine(" 3. Fibonacci Sequence Generator  ");
                Console.WriteLine(" 4. Greatest Common Divisor (GCD)   ");
                Console.WriteLine(" 5. Sum of Digits ");
                Console.WriteLine(" 6. Array Average  ");
                Console.WriteLine(" 7. Count Vowels in a String  ");
                Console.WriteLine(" 8. Temperature Converter  ");
                Console.WriteLine(" 9. Word Count  ");
                Console.WriteLine(" 10. String Capitalization  ");
                // Menuchoice = int.Parse(Console.ReadLine());
                Menuchoice = handelIntError(Console.ReadLine());
                switch (Menuchoice)
                {
                    case 1:
                        double num;
                        Console.WriteLine("enter number: ");
                        num = handelDoubleError(Console.ReadLine());

                        Console.WriteLine(CalculateFactoria(num));
                        break;

                    case 2:
                        double in_num;
                        bool is_prime;
                        Console.WriteLine("enter number: ");
                        in_num = handelDoubleError(Console.ReadLine());
                        is_prime = IsPrime(in_num);

                        if (is_prime == true)
                        {
                            Console.WriteLine("Tis numer is prime");
                        }
                        else
                        {
                            Console.WriteLine("Tis numer is not prime");
                        }
                        break;

                    case 3:

                        Console.WriteLine("enter number: ");
                        int fnum = handelIntError(Console.ReadLine());
                        List<int> fibonacci = new List<int>();
                        fibonacci = GenerateFibonacci(fnum);
                        Console.Write("[");
                        for (int i = 0; i < fibonacci.Count; i++)
                        {
                            Console.Write(fibonacci[i] + " ");
                        }
                        Console.WriteLine("]");
                        break;

                    case 4:
                        Console.WriteLine("enter 2 numbers: ");
                        int n1 = handelIntError(Console.ReadLine());
                        int n2 = handelIntError(Console.ReadLine());

                        Console.WriteLine("The greatest common number of "
                            + n1 + " and " + n2 + " is " + GCD(n1, n2));

                        break;

                    case 5:
                        int digits;
                        Console.WriteLine("enter number: ");
                        digits = handelIntError(Console.ReadLine());

                        Console.WriteLine("the sum of digits is  " + SumOfDigits(digits));

                        break;

                    case 6:
                        List<int> x_array = new List<int>();
                        int input;
                        Console.WriteLine("how many numbers you want to add? ");
                        int count = handelIntError(Console.ReadLine());

                        Console.WriteLine("enter your numbers: ");
                        for (int i = 0; i < count; i++)
                        {
                            input = handelIntError(Console.ReadLine());
                            x_array.Add(input);
                        }
                        Console.WriteLine(" the avrage is "
                            + CalculateAverage(x_array));

                        break;

                    case 7:
                        string world;
                        Console.WriteLine("enter world ");
                        world = Console.ReadLine();
                        Console.WriteLine("the number of vowels litter in "
                            + world + " is : " + CountVowels(world));

                        break;

                    case 8:
                        double degree;
                        Console.WriteLine("convert temperature to:  (enter 1 or 2)" +
                            " \n 1.Celsius \n 2.Fahrenhei (enter 1 or 2)");
                        int choice = handelIntError(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("entet temperature dgree in Fahrenhei ");
                            degree = handelDoubleError(Console.ReadLine());
                            Console.WriteLine("The degree is : " + FahrenheitToCelsius(degree));
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("entet temperature dgree in Celsius  ");
                            degree = handelDoubleError(Console.ReadLine());
                            Console.WriteLine("The degree is : " + CelsiusToFahrenheit(degree));
                        }
                        else
                        {
                            Console.WriteLine("Invalid input..  ");
                        }
                        break;

                    case 9:

                        Console.WriteLine("Enter your sentence ");
                        string inputSen = Console.ReadLine();
                        Console.WriteLine("the number of world is : " + CountWords(inputSen));

                        break;

                    case 10:
                        string inString;
                        Console.WriteLine("Enter your sentance ");
                        inString = Console.ReadLine();
                        Console.WriteLine("Output : " + CapitalizeFirstLetter(inString));

                        break;

                    default:
                        Console.WriteLine("Ivalid number.. ");
                        break;



                }
                Console.WriteLine("Do you want to continue?(enter 1 or 2) \n 1.yes \n 2.no");
                ContnueChoise = handelIntError(Console.ReadLine());
                if (ContnueChoise == 1) { flag = true; }
                else if (ContnueChoise == 2)
                { flag = false; }
                else
                {
                    Console.WriteLine("Ivalid number.. ");
                    flag = false;
                }

            }




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
