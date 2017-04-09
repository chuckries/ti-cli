namespace TwilightImperium
{
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
}