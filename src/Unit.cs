namespace TI
{
    public interface IDamageable
    {
        bool IsDamaged { get; set; }
    }

    public interface IMoveable
    {
        void Move();
    }

    public interface IUnit
    {
        byte Cost { get; }
        byte Roll { get; }
        byte Movement { get; }
    }

    internal abstract class Unit : IUnit
    {
        public byte Cost { get; protected set; }

        public byte Roll { get; protected set; }

        public byte Movement { get; protected set; }

        internal Unit(byte cost, byte roll, byte movement)
        {
            Cost = cost;
            Roll = roll;
            Movement = movement;
        }
    }
}