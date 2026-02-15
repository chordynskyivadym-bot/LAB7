namespace LAB7
{
    internal class Task3
    {
        static void Main(string[] args)
        {
            Func<double, double> discountCalculator = (price) => price * 0.95;

            discountCalculator += (price) => price * 0.90;
            discountCalculator += (price) => price - 100;

            double initialPrice = 1000;

            Console.WriteLine("СПРОБА 1: Стандартний виклик (Неправильно)");
            double wrongResult = discountCalculator(initialPrice);
            Console.WriteLine($"Ціна: {wrongResult} грн");

            Console.WriteLine("\nСПРОБА 2: Ручний прохід по списку (Правильно)");

            double currentPrice = initialPrice;

            foreach (Func<double, double> discount in discountCalculator.GetInvocationList())
            {
                double previousPrice = currentPrice;
                currentPrice = discount(currentPrice);

                Console.WriteLine($"Застосовано знижку: {previousPrice} -> {currentPrice}");
            }

            Console.WriteLine($"\nФінальна ціна: {currentPrice} грн");
        }
    }
}
