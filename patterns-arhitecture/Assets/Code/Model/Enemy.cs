using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class Enemy : MonoBehaviour, IEnemy
    {
        #region Fields

        private Enemy _enemyPrefab;

        public Action<Enemy> OnClone;
        public Action<GameObject> OnTriggerEnterChanging;
        public event Action<GameObject> OnTriggerEnterChangedEvent;

        #endregion


        #region Properties

        public HealthOfEnemy Health { get; private set; }

        public int Points { get; private set; }

        #endregion


        #region Methods

        public Enemy CreateEnemy(Enemy enemyPrefab, int health, int points)
        {
            var enemy = Instantiate(enemyPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = enemyPrefab;
            return enemy;
        }

        internal Enemy Clone()
        {
            var enemy = Instantiate(_enemyPrefab);
            enemy.Points = Points;
            enemy.Health = new HealthOfEnemy(Health.MaxHealth, Health.CurrentHealth);

            enemy._enemyPrefab = _enemyPrefab;
            OnClone?.Invoke(enemy);
            return enemy;
        }

        #endregion
    }
}
