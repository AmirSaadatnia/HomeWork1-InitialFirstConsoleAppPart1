namespace homework1;

class Program
{git branch
    static void Main(string[] args)
    {
        //task1
        int age = 18;
        Console.WriteLine(age);

        const string wellcomeMessage = "Wellcome to C#";
        Console.WriteLine(wellcomeMessage);

        Console.ReadKey();

        
        
        
        
        //task2
        Console.WriteLine("Please enter your fullname:");
        string fullname = Console.ReadLine();
        Console.WriteLine("Please enter your age:");
        int age1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Hello, {fullname}. You are {age1} years old.");
        Console.ReadKey();

        
        
        
        
        //task3
        const int i = 3;
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine("Please guess a number between 1 to 10:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            while (i == number1)
            {
                Console.WriteLine("Congratulations");
                Console.ReadKey();
            }
        }

        Console.WriteLine($"Correct Answer = {i}");
        Console.ReadKey();

        
        
        
        //task4
        string guessKey = "CSharp";
        string guess = "";
        int counter = 0;

        while (guess != guessKey)
        {
            Console.Write("Guess the word: ");
            guess = Console.ReadLine();

            counter++;

            if (guess != guessKey)
            {
                Console.WriteLine("Wrong guess. Try again.");
            }
        }

        Console.WriteLine("Congratulations");
        Console.WriteLine($"Total try: {counter}");
        
        
        
        
        
        //task5
        
        int n;
        int sum = 0;
        
        do
        {
            Console.Write("please enter a positive number and greater equal than 1: ");
            n = Convert.ToInt32(Console.ReadLine());

            if (n < 1)
            {
                Console.WriteLine("Wrong");
            }

        } while (n < 1);
        
        for (int f = 1; f <= n; f++)
        {
            if (f % 2 != 0)
            {
                sum += f;
            }
        }

        Console.WriteLine($"Sum of odd numbers from 1 to {n} = {sum}");
    }
}