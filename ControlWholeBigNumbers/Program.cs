using ControlWholeBigNumbers;

internal class Program
{
    static void Main(string[] args)
    {
        OperationsAboveNumbers operationsAboveNumbers = new OperationsAboveNumbers();

        Console.WriteLine("\tОперации с числами\n");

        long userInputFirst = 0;
        long userInputLast = 0;

        Console.Write("Первое значение: ");
        try
        {
            userInputFirst = Convert.ToInt64(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ввод должен быть числом");
        }

        Console.Write("Второе значение: ");
        try
        {
            userInputLast = Convert.ToInt64(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Ввод должен быть числом");
        }

        Console.WriteLine("\nСложение - 1\nВычитание - 2\nУмножение - 3\nДеление - 4\n");
        ConsoleKeyInfo userKey = Console.ReadKey();
        switch (userKey.Key)
        {
            case ConsoleKey.D1:
                Console.WriteLine($"Команда: {userKey.Key}");
                operationsAboveNumbers.AdditionBigNumbers(userInputFirst, userInputLast);
                break;
            case ConsoleKey.D2:
                Console.WriteLine($"Команда: {userKey.Key}");
                operationsAboveNumbers.SubtractionBigNumbers(userInputFirst, userInputLast);
                break;
            case ConsoleKey.D3:
                Console.WriteLine($"Команда: {userKey.Key}");
                operationsAboveNumbers.MultiplicationBigNumbers(userInputFirst, userInputLast);
                break;
            case ConsoleKey.D4:
                Console.WriteLine($"Команда: {userKey.Key}");
                operationsAboveNumbers.DivisionBigNumbers(userInputFirst, userInputLast);
                break;
            default:
                Console.WriteLine("Такой команды нету");
                break;
        }

    }
}