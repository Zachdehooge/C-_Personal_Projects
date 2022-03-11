class Program
{

    void Interaction()
    {
        Console.WriteLine("\n" + "Enter the first number: ");
        int first = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("\n" + "Enter \"+, -, /, or *\"");
        String getOperator = Console.ReadLine();

        Console.WriteLine("\n" + "Enter the second number: ");
        int second = Convert.ToInt16(Console.ReadLine());

        if(getOperator == "+")
        {
            Console.Write("\n" + first + " + " + second + " = " + (first + second) + "\n");
        }
        if(getOperator == "-")
        {
            Console.Write("\n" + first + " - " + second + " = " + (first - second) + "\n");
        }
        if (getOperator == "/")
        {
            Console.Write("\n" + first + " / " + second + " = " + (first / second) + "\n");
        }
        if (getOperator == "*")
        {
            Console.Write("\n" + first + " * " + second + " = " + (first * second) + "\n");
        }

        ready();

    }

    void ready()
    {
        // Prompts the user if they would like to perform another calculation

        Console.WriteLine("\n" + "Would you like to calculate another number?[y/n]: ");
        String answer = Console.ReadLine();

        if (answer == "y" || answer == "Y")
        {
            Interaction();
        }
        if (answer == "n" || answer == "N")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Please enter y or n");
            ready();
        }
    }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.Interaction();
        }
}