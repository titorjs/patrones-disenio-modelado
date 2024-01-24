namespace DecoratorEj.Models
{
    public interface IEnemigo
    {
        int Health { get; }
        int TakeDamage(int damage);
    }
}
