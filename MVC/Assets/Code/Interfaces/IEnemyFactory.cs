

namespace MVC
{
    public interface IEnemyFactory
    {
        IEnemy CreateEnemy(EnemyType enemyType);
    }
}
