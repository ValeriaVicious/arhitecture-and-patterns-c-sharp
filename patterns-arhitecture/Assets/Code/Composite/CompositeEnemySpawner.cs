

using System;
using System.Collections.Generic;

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class CompositeEnemySpawner : ISpawner
    {
        #region Fields

        public event Action<IEnemy> OnSpawnEnemy;
        public List<ISpawner> _spawners = new List<ISpawner>();

        #endregion


        #region Methods

        public void AddSpawner(ISpawner spawner)
        {
            spawner.OnSpawnEnemy += OnSpawnEnemy;
            _spawners.Add(spawner);
        }

        public void RemoveSpawner(ISpawner spawner)
        {
            spawner.OnSpawnEnemy -= OnSpawnEnemy;
            _spawners.Remove(spawner);
        }

        #endregion
    }
}
