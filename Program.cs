namespace Ev_tapsirigi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 20;
            string Calculator = "*";
            int sum = 0;
            switch (Calculator)
            {
                case "+":
                    sum = num1 + num2;
                    break;
                case "-":
                    sum = num2 - num1;
                    break;
                case "*":
                    sum = num1 * num2;
                    break;
                case "/":
                    sum = num1 / num2;
                    break;

            }
            Console.WriteLine(sum);
        }
       }
}