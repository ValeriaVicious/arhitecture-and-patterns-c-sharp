

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IEnemyFactory
    {
        public IEnemy CreateEnemy(TypeOfEnemy enemy);
    }
}
