namespace Linq.DynamicSum.UnitTests.TestModel
{
    public class PercentageObject
    {
        public PercentageObject()
        {
            Product = string.Empty;
            WinLost = 0;
            Turnover = 0;
        }

        public string Product { get; set; }

        public decimal WinLost { get; set; }

        public decimal Turnover { get; set; }

        public decimal Margin
        {
            get
            {
                return Turnover == 0
                    ? 0
                    : WinLost / Turnover;
            }
        }

        public static PercentageObject operator +(PercentageObject object1, PercentageObject object2)
        {
            return new PercentageObject
            {
                Product = object1.Product,
                WinLost = object1.WinLost + object2.WinLost,
                Turnover = object1.Turnover + object2.Turnover
            };
        }
    }
}
