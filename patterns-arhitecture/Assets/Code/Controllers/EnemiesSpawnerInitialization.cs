using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemiesSpawnerInitialization : IInitialization, ICleanup
    {
        #region Fields

        private CompositeEnemySpawner _compositeEnemySpawner;
        private List<EnemiesSpawner> _enemiesSpawner;

        #endregion


        #region ClassLifeCycles

        public EnemiesSpawnerInitialization(IEnumerable<Enemy> enemies)
        {
            _compositeEnemySpawner = new CompositeEnemySpawner();
            _enemiesSpawner = new List<EnemiesSpawner>();
            foreach (var item in enemies)
            {
                var enemySpawner = new EnemiesSpawner(item);
                _compositeEnemySpawner.AddSpawner(enemySpawner);
                _enemiesSpawner.Add(enemySpawner);
            }

        }

        #endregion


        #region Methods

        public IEnumerable<EnemiesSpawner> GetEnemiesSpawners()
        {
            foreach (var item in _enemiesSpawner)
            {
                yield return item;
            }
        }

        public ISpawner GetSpawner()
        {
            return _compositeEnemySpawner;
        }

        public void Initiallization()
        {
            foreach (var item in _enemiesSpawner)
            {
                item.Initiallization();
            }
        }

        public void CleanUp()
        {
            foreach (var item in _enemiesSpawner)
            {
                item.CleanUp();
            }
        }


        #endregion
    }
}
