namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

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

        }


    }
}
