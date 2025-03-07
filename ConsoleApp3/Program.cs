namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("select the type of conversion:");

            Console.WriteLine("1. from double to decimal");
            Console.WriteLine("2. from decimal to double");
            Console.WriteLine("3. from decimal to hexadecimal");
            Console.WriteLine("4. from hexadecimal to decimal");
            Console.WriteLine("5. from double to hexadecimal");
            Console.WriteLine("6. from hexadecimal to double");

            var input = Console.ReadLine();
            var number = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine(C2_10(int.Parse(number)).ToString());
                    break;
                case "2":
                    Console.WriteLine(C10_2(int.Parse(number)).ToString());
                    break;
                case "3":
                    Console.WriteLine(C10_16(int.Parse(number)).ToString());
                    break;
                case "4":
                    Console.WriteLine(C16_10(number).ToString());
                    break;
                case "5":
                    Console.WriteLine(C16_10(C2_10(int.Parse(number)).ToString()));
                    break;
                case "6":
                    Console.WriteLine(C10_2(int.Parse(C16_10(number).ToString())));

                    break;
            }




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

        static int C2_10(int input)
        {
            // 2 - 10


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

        static int C10_2(int input)
        {
            if(input == 0)
            {
                return 0;
            }
            string output = "";
            int a = 0;

            while (input >= 1)
            {

                output += input % 2;
                input /= 2;
                Console.WriteLine(output);

            }
            string final = "";
            int b = 0;
            for (int i = output.Length - 1; i >= 0; i--)
            {
                final += output[i];
            }
            return int.Parse(final);
        }
        static string C10_16(int input)
        {
            // 10 - 16
            string output = "";


            while (input >= 1)
            {


                switch (input % 16)
                {
                    case 10:
                        output += "A"; break;
                    case 11:
                        output += "B"; break;
                    case 12:
                        output += "C"; break;
                    case 13:
                        output += "D"; break;
                    case 14:
                        output += "E"; break;
                    case 15:
                        output += "F"; break;
                    default:
                        output += (input % 16).ToString();
                        break;
                }
                input /= 16;


            }
            string final = "";
            int b = 0;
            for (int i = output.Length - 1; i >= 0; i--)
            {
                final += output[i];
            }
            return final;
        }
        static int C16_10(string input)
        {
            
            int sum = 0;
            string digits10 = input;
            int counter = digits10.Length;


            foreach (char c in digits10)
            {
                switch (c.ToString())
                {
                    case "A":
                        counter--;
                        int digit = 10;
                        sum += digit * Power(counter, 16); break;
                    case "B":
                        counter--;
                        digit = 11;
                        sum += digit * Power(counter, 1 * 16); break;
                    case "C":
                        counter--;
                        digit = 12;
                        sum += digit * Power(counter, 1 * 16); break;
                    case "D":
                        counter--;
                        digit = 13;
                        sum += digit * Power(counter, 1 * 16); break;
                    case "E":
                        counter--;
                        digit = 14;
                        sum += digit * Power(counter, 1 * 16); break;
                    case "F":
                        counter--;
                        digit = 15;
                        sum += digit * Power(counter, 1 * 16); break;
                    default:
                        counter--;
                        digit = int.Parse(c.ToString());
                        sum += digit * Power(counter, 1 * 16);
                        break;
                }
                


            }

            return sum;


            
        }

    }
}
