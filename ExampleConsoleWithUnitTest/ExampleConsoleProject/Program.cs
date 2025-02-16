using LogicProject;
using ControllerProject;

namespace ExampleConsoleProject
{

    public class Program
    {
        public static void ShowMoney(Money money)
        {
            Console.WriteLine(money.MoneyInfo());
        }
        public static void ShowMessage(string message, bool error = false)
        {
            ConsoleColor color = Console.ForegroundColor;
            if (error)
                Console.ForegroundColor = ConsoleColor.Red;
            else
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = color;
        }
        public static void IncreaseRubles(ref Money money)
        {
            string message = Controller.TryIncreaseRubles(ref money);
            if (message == "")
            {
                ShowMoney(money);
            }
            else
            {
                ShowMessage(message, true);
            }
        }
        public static void SumMas(int[] mas)
        {
            int result;
            string error = Controller.TrySumMas(mas, out result);
            if (error == "")
            {
                Console.WriteLine(result);
            }
            else
            {
                ShowMessage(error, true);
            }
        }

        public static double SumMoneysInRubles(Money[] moneys)
        {
            double result = 0.0;
            foreach (Money money in moneys)
            {
                result += money.Rub + money.Kop / 100.0;
            }
            return result;
        }

        static void Main(string[] args)
        {
            ShowMessage("----| Проверка суммирования элементов массива |----");
            SumMas(new int[] { 1, 2, 3, 4, 5 });
            SumMas(new int[] { 2000000000, 2000000000 });
            SumMas(new int[] { });
            ShowMessage("------| Создание трёх элементов типа Money |------");
            Money m1 = new Money(10, 5);
            Money m2 = new Money(100, 5);
            Money m3 = new Money(10, 105);
            ShowMoney(m1);
            ShowMoney(m2);
            ShowMoney(m3);
            ShowMessage("---| Добавление рубля к каждому объекту типа Money |---");
            IncreaseRubles(ref m1);
            IncreaseRubles(ref m2);
            IncreaseRubles(ref m3);
            ShowMessage("---| Сумма в рублях всех Money в массиве |---");
            Money[] moneys = new Money[] { m1, m2, m3 };
            Console.WriteLine(SumMoneysInRubles(moneys));
        }
    }

}