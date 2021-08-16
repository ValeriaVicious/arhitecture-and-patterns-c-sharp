using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyInitialization : IInitialization
    {
        #region Fields

        private Enemy _enemy;
        private IMoveEnemy _moveTheEnemy;

        #endregion


        #region Properties

        public Enemy Enemy => _enemy;
        public IMoveEnemy GetMoveEnemy => _moveTheEnemy;

        #endregion


        #region ClassLifeCycles

        public EnemyInitialization(EnemyConfig enemyConfig)
        {
            _enemy = Object.Instantiate(enemyConfig.EnemyPrefab);
        }

        #endregion


        #region Methods

        public void Initiallization()
        {

        }
        public IMoveEnemy Move()
        {
             return _moveTheEnemy;
        }

        #endregion
    }
}
