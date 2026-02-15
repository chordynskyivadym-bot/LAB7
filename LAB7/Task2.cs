
namespace LAB7
{
    public class BankTerminal
    {
        public event Action<int> OnMoneyWithdraw;

        public void Withdraw(int amount)
        {
            Console.WriteLine($"Видаємо {amount} грн");

            OnMoneyWithdraw?.Invoke(amount);
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            BankTerminal terminal = new BankTerminal();

            terminal.OnMoneyWithdraw += (sum) => Console.WriteLine($"SMS: Знято {sum} грн.");

            terminal.Withdraw(500);

            Console.WriteLine("\nПОЧАТОК ЗЛОМУ");

            //terminal.OnMoneyWithdraw.Invoke(999999);

            //terminal.OnMoneyWithdraw = null;

            Console.WriteLine("Не можливо зламати термінал. Вибиває помилку");
        }
    }
}
