using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class EnemiesSpawner : ISpawner, IInitialization, ICleanup
    {

        #region Fields

        private Vector3 _position;
        private Enemy _enemy;

        public event Action<IEnemy> OnSpawnEnemy;

        #endregion


        #region ClassLifeCycles

        public EnemiesSpawner(Enemy enemyPrefab)
        {
            _position = enemyPrefab.transform.position;
            _enemy = enemyPrefab;
        }

        #endregion


        #region Methods

        private Enemy Spawn()
        {
            var enemyClone = _enemy.Clone();
            enemyClone.Health.ChangeCurrentHealth(enemyClone.Health.MaxHealth);
            enemyClone.transform.position = _position;
            enemyClone.OnTriggerEnterChangedEvent += OnTriggerEnemy;
            OnSpawnEnemy?.Invoke(enemyClone);
            return enemyClone;
        }

        public void Initiallization()
        {
            _enemy.OnTriggerEnterChanging += OnTriggerEnemy;
        }

        private void OnTriggerEnemy(GameObject obj)
        {
            if (obj.GetComponent<Bullet>() || obj.GetComponent<Player>())
            {
                _enemy.Health.ChangeCurrentHealth(_enemy.Health.CurrentHealth - 1);
                if (_enemy.Health.CurrentHealth <= 0)
                {
                    _enemy.OnTriggerEnterChangedEvent -= OnTriggerEnemy;
                    var spawnNewEnemy = Spawn();
                    UnityEngine.Object.Destroy(_enemy.gameObject);
                    _enemy = spawnNewEnemy;
                }
            }
        }

        public void CleanUp()
        {
            _enemy.OnTriggerEnterChanging -= OnTriggerEnemy;
        }

        #endregion
    }
}
