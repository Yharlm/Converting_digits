namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string output = "";
			int a = 0;
            int input = 18;
            while (input >= 1)
            {
                
                output += input % 2;
                input /= 2;
                Console.WriteLine(output);
                
            }
            string final = "";
            int b = 0;
            for(int i = output.Length-1;i >= 0;i--)
            {
              final += output[i];
            }
            Console.WriteLine(final);
            
        }

        static int Power(int n, int a)
        {
            int starter = a;
            if (n == 0)
            {
                return 1;
            }
            for (int i = 1; i < n; i++)
            {
                a *= starter;
            }
            return a;
        }

        static int C10_2()
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            string digits10 = input.ToString();
            int counter = digits10.Length;


            foreach (char c in digits10)
            {
                counter--;
                int digit = int.Parse(c.ToString());
                sum += digit * Power(counter, digit * 2);

            }

            return sum;
        }

        
    }
}
