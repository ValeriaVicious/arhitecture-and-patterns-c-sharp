using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyInitialization : IInitialization
    {
        #region Fields

        private Enemy _enemy;

        #endregion


        #region Properties

        public Enemy Enemy => _enemy;

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

        #endregion
    }
}
