using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemiesSpawnerInitialization : IInitialization
    {
        #region Fields

        private GameObject _enemiesSpawner;

        #endregion


        #region Properties

        public GameObject EnemiesSpawner => _enemiesSpawner;

        #endregion


        #region ClassLifeCycles

        public EnemiesSpawnerInitialization(EnemySpawnerConfig enemySpawnerConfig)
        {
            _enemiesSpawner = Object.Instantiate(enemySpawnerConfig.Spawner);
        }

        #endregion


        #region Methods

        public void Initiallization()
        {

        }

        #endregion
    }
}
