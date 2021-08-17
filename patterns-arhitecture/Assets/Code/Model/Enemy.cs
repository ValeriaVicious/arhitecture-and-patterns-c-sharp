using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public class Enemy : MonoBehaviour, IEnemy
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

        public static Asteroid CreateAsteroid(Asteroid enemyPrefab, int health, int points)
        {
            var enemy = Instantiate(enemyPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = enemyPrefab;
            return enemy;
        }

        internal static Allien CreateAllien(Allien allienPrefab, int health, int points)
        {
            var enemy = Instantiate(allienPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = allienPrefab;
            return enemy;
        }

        internal static UFO CreateUFO(UFO ufoPrefab, int health, int points)
        {
            var enemy = Instantiate(ufoPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = ufoPrefab;
            return enemy;
        }

        internal static Ship CreateShip(Ship shipPrefab, int health, int points)
        {
            var enemy = Instantiate(shipPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = shipPrefab;
            return enemy;
        }

        public static GreenShip CreateGreenShip(GreenShip greenShipPrefab, int health, int points)
        {
            var enemy = Instantiate(greenShipPrefab);
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = greenShipPrefab;
            return enemy;
        }

        public Enemy Clone()
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
