namespace TwilightImperium
{
    public abstract class Unit
    {
        public readonly int Cost;

        protected Unit(int cost)
        {
            Cost = cost;
        }
    }
}