namespace LogicProject
{

    public class Money
    {
        int rub;
        int kop;

        static int count = 0;

        private static int Count
        {
            get => count;
        }

        public int Rub
        {
            private set
            {
                if (value >= 0 && value <= 100)
                    rub = value;
                else
                    throw new Exception("Рубли должны быть от 0 до 100");
            }
            get
            {
                return rub;
            }
        }
        public int Kop
        {
            set
            {
                if (value >= 0 && value < 100)
                    kop = value;
                else if (value >= 100)
                {
                    Rub += value / 100;
                    kop = value % 100;
                }
                else
                    throw new Exception("Копейки не могут быть отрицательными!");
            }
            get => kop;
        }

        public Money()
        {
            rub = 0;
            kop = 0;
            count++;
        }
        public Money(int r, int k)
        {
            Rub = r;
            Kop = k;
            count++;
        }
        public Money(Money money)
        {
            Rub = money.Rub;
            Kop = money.Kop;
            count++;
        }
        
        public string MoneyInfo()
        {
            return $"{rub} руб. {kop} коп.";
        }

        // В данных методах идёт работа с консолью!
        //public void ShowMoney(bool ok)
        //{
        //    Console.WriteLine($"{rub} руб. {kop} коп.");
        //}
        //public static void ShowMoney(Money money)
        //{
        //    Console.WriteLine($"{money.Rub} руб. {money.Kop} коп.");
        //}

        public static int GetCount()
        {
            return Count;
        }

        public static Money operator ++(Money m)
        {
            Money res = new Money(m);
            res.Kop = res.Kop + 1;
            return res;
        }
        public static Money operator !(Money m)
        {
            Money res = new Money(m);
            res.Rub = res.Rub + 1;
            return res;
        }

        public static bool operator ==(Money m1, Money m2)
        {
            return m1.Rub == m2.Rub && m1.Kop == m2.Kop;
        }
        public static bool operator !=(Money m1, Money m2)
        {
            return m1.Rub != m2.Rub && m1.Kop != m2.Kop;
        }
    }

}