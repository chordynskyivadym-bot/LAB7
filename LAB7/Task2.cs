
namespace LAB7
{
    public class BankTerminal
    {
        public Action<int> OnMoneyWithdraw;

        public void Withdraw(int amount)
        {
            Console.WriteLine($"[Термінал] Видаємо {amount} грн...");

            OnMoneyWithdraw?.Invoke(amount);
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            BankTerminal terminal = new BankTerminal();

            terminal.OnMoneyWithdraw += (sum) => Console.WriteLine($"> SMS: Знято {sum} грн.");

            terminal.Withdraw(500);

            Console.WriteLine("\nПОЧАТОК ЗЛОМУ");

            terminal.OnMoneyWithdraw.Invoke(999999);

            terminal.OnMoneyWithdraw = null;

            Console.WriteLine("Намагаємось зняти гроші після злому:");
            terminal.Withdraw(200);
        }
    }
}
