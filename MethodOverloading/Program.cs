namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Print("Please enter two numbers:");

            var a = ValidateNumInput();

            Print("Please enter your second number:");

            var b = ValidateNumInput();

            Print("Do you want this as dollars?");

            string answer = GetYorN();

            bool doDollars = answer == "y";

            Print("Do you want to enforce whole numbers?");

            answer = GetYorN();

            bool doWholeNum = answer == "y";

            if (doDollars)
                Print($"Addition: {(int)a} + {(int)b} = {Add((int)a, (int)b, doDollars)}");
            else if (doWholeNum)
                Print($"Addition: {(int)a} + {(int)b} = {Add((int)a, (int)b)}");
            else
                Print($"Addition: {a} + {b} = {Add(a, b)}");
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        static string Add(int a, int b, bool isValid)
        {
            if (isValid)
                return $"{a + b} dollar" + (a + b == 1 ? "" : "s");

            return (a + b).ToString();
        }

        static decimal ValidateNumInput()
        {
            decimal val;
            while (!decimal.TryParse(Console.ReadLine(), out val))
            {
                Print("Please input an integer.");
            }

            return val;
        }

        static string GetYorN()
        {
            string answer = Console.ReadLine().ToLower();
            while (answer != "y" && answer != "n")
            {
                Print("Please only input Y or N");
                answer = Console.ReadLine().ToLower();
            }

            return answer;
        }

        static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
