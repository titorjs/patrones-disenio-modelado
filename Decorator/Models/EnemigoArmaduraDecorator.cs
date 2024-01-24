namespace DecoratorEj.Models
{
    public class EnemigoArmaduraDecorator : IEnemigoDecorator
    {
        private IEnemigo enemigo;
        public EnemigoArmaduraDecorator(IEnemigo enemigo)
        {
            this.enemigo = enemigo;
        }
        public int Health => enemigo.Health;
        public int TakeDamage(int damage)
        {
            int reducido = damage / 3;
            return enemigo.TakeDamage(reducido);
        }
    }
}
