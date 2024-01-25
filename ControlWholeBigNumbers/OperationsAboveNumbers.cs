namespace ControlWholeBigNumbers
{
    public class OperationsAboveNumbers
    {
        public void AdditionBigNumbers(long value1, long value2)
        {
            long result = value1 + value2;
            Console.WriteLine($"Результат сложения: {result}");
        }

        public void SubtractionBigNumbers(long value1, long value2)
        {
            long result = value1 - value2;
            Console.WriteLine($"Результат вычитания: {result}");
        }

        public void MultiplicationBigNumbers(long value1, long value2)
        {
            long result = value1 * value2;
            Console.WriteLine($"Результат умножения: {result}");
        }

        public void DivisionBigNumbers(long value1, long value2)
        {
            long result = value1 / value2;
            Console.WriteLine($"Результат деления: {result}");
        }

    }
}
