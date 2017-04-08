namespace TI { namespace Unit {

    public interface IUnit
    {
        byte Cost { get; }
    }

    public interface ICombatant
    {
        byte Roll { get; }
    }

    public interface IMoveable
    {
        byte Movement { get; }
        void Move();
    }

    public interface IDamageable
    {
        bool IsDamaged { get; set; }
    }

    internal abstract class Unit : IUnit
    {
        public byte Cost { get; protected set; }

        internal Unit(byte cost)
        {
            Cost = cost;
        }
    }

} // namespace Unit
} // namepsace TI