namespace LAB7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Action> action = new List<Action>();

            for(int i = 1; i <= 5; i++)
            {
                int index = i;
                action.Add(() => Console.WriteLine(index));
            }

            foreach (var item in action)
            {
                item();
            }
        }
    }
}
