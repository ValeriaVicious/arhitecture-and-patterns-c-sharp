using UnityEngine;


namespace MVC
{
    public sealed class EnemyFactory : IEnemyFactory
    {
        #region Fields

        private readonly EnemyData _enemyData;

        #endregion


        #region ClassLifeCycles

        public EnemyFactory(EnemyData data)
        {
            _enemyData = data;
        }

        #endregion


        #region Methods

        public IEnemy CreateEnemy(EnemyType enemyType)
        {
            var enemyProvider = _enemyData.GetEnemy(enemyType);
            return Object.Instantiate(enemyProvider);
        }

        #endregion
    }
}
