class Program
{

    class BankrutException : ApplicationException
    {
        public BankrutException(string msg) : base(msg) { }
    }

    class Money
    {
        private int kop; 

        public Money(int grn, int kopiyky)
        {
            kop = grn * 100 + kopiyky;
            if (kop < 0) throw new BankrutException("Банкрут!");
        }

        private static void Check(Money m)
        {
            if (m.kop < 0) throw new BankrutException("Банкрут!");
        }

        public override string ToString()
        {
            return $"{kop / 100} грн {kop % 100} коп";
        }

        public static Money operator +(Money a, Money b)
        {
            Money r = new Money(0, a.kop + b.kop);
            Check(r);
            return r;
        }

        public static Money operator -(Money a, Money b)
        {
            Money r = new Money(0, a.kop - b.kop);
            Check(r);
            return r;
        }

        public static Money operator *(Money a, int n)
        {
            Money r = new Money(0, a.kop * n);
            Check(r);
            return r;
        }

        public static Money operator /(Money a, int n)
        {
            Money r = new Money(0, a.kop / n);
            Check(r);
            return r;
        }

        public static Money operator ++(Money a)
        {
            a.kop++;
            Check(a);
            return a;
        }

        public static Money operator --(Money a)
        {
            a.kop--;
            Check(a);
            return a;
        }

        public static bool operator >(Money a, Money b) => a.kop > b.kop;
        public static bool operator <(Money a, Money b) => a.kop < b.kop;
        public static bool operator ==(Money a, Money b) => a.kop == b.kop;
        public static bool operator !=(Money a, Money b) => a.kop != b.kop;

        public override bool Equals(object obj)
        {
            if (obj is Money m) return m.kop == kop;
            return false;
        }

        public override int GetHashCode() => kop.GetHashCode();
    }

static void Main()
    {
        try
        {
            Money a = new Money(10, 50);
            Money b = new Money(3, 20);

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * 2 = " + (a * 2));
            Console.WriteLine("a / 2 = " + (a / 2));

            a++;
            Console.WriteLine("a++ = " + a);

            b--;
            Console.WriteLine("b-- = " + b);

            Console.WriteLine("a > b: " + (a > b));
            Console.WriteLine("a < b: " + (a < b));
            Console.WriteLine("a == b: " + (a == b));
        }
        catch (BankrutException ex)
        {
            Console.WriteLine("ПОМИЛКА: " + ex.Message);
        }
    }
}
