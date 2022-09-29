namespace converter
{
    public class Converter
    {
        private static double usd, eur, rub;
        private string currensyValue;

        public string CurrensyValue
        {
            get { return currensyValue; }
        }

        public Converter(double usdValue, double eurValue, double rubValue, string currensyValue)
        {
            usd = usdValue;
            eur = eurValue;
            rub = rubValue;
            this.currensyValue = currensyValue;
        }

        public enum Currency
        {
            USD,
            EUR,
            RUB
        }


        public double Convert(Currency to, double currensyValue)
        {
            double result = 0;
            switch (to)
            {
                case Currency.USD:
                    result = currensyValue / usd; break;
                case Currency.EUR:
                    result = currensyValue / eur; break;
                case Currency.RUB:
                    result = currensyValue / rub; break;
                default: break; ;
            }
            return result;
        }

        public double Convert(double amount, Currency of)
        {
            double result = 0;
            switch (of)
            {
                case Currency.USD:
                    result = usd * amount; break;
                case Currency.EUR:
                    result = eur * amount; break;
                case Currency.RUB:
                    result = rub * amount; break;
                default: break; ;

            }
            return result;
        }
    }
}