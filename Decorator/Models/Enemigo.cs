namespace DecoratorEj.Models
{
    public class Enemigo : IEnemigo
    {
        private int vida;
        public Enemigo()
        {
            vida = 100;
        }
        public int Health => vida;
        public int TakeDamage(int damage)
        {
            return vida-=damage;
        }
    }
}
