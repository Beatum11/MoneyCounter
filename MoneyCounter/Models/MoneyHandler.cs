namespace MoneyCounter.Models
{
    public class MoneyHandler
    {
        public int Spend { get; set; }

        public int Left { get; set; }

        public int Limit { get; set; }


        #region Constructors
        public MoneyHandler(int limit)
        {
            Limit = limit;
        }

        public MoneyHandler()
        {

        }
        #endregion
    }
}
