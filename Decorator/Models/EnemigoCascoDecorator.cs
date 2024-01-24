namespace DecoratorEj.Models
{
    public class EnemigoCascoDecorator : IEnemigoDecorator
    {
        private IEnemigo enemigo;
        public EnemigoCascoDecorator(IEnemigo enemigo)
        {
            this.enemigo = enemigo;
        }
        public int Health => enemigo.Health;
        public int TakeDamage(int damage)
        {
            int reducido = damage / 2;
            return enemigo.TakeDamage(reducido);
        }
    }
}
