namespace TI
{
    public interface IDamageable
    {
        bool IsDamaged { get; set; }
    }

    public abstract class Unit
    {
        public byte Cost { get; protected set; }

        public byte Roll { get; protected set; }

        public byte Movement { get; protected set; }

        protected Unit(byte cost, byte roll, byte movement)
        {
            Cost = cost;
            Roll = roll;
            Movement = movement;
        }
    }
}