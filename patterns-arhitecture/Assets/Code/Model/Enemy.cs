using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public class Enemy : MonoBehaviour, IEnemy
    {
        #region Fields

        private Enemy _enemyPrefab;
        private TypeOfEnemy _typeOfEnemy;

        public event Action<Enemy> OnClone;
        public event Action<GameObject> OnTriggerEnterChangedEvent;
        public Action<string> OnDestroy;

        #endregion


        #region Properties

        public HealthOfEnemy Health { get; private set; }
        public int Points { get; private set; }
        public int Damage { get; private set; }
        public TypeOfEnemy TypeOfEnemy { get; private set; }

        #endregion


        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnTriggerEnterChangedEvent?.Invoke(collision.gameObject);
        }

        #endregion


        #region Methods

        public static Asteroid CreateAsteroid(Asteroid enemyPrefab, int health, int points, int damage)
        {
            var enemy = Instantiate(enemyPrefab);
            enemy.TypeOfEnemy = TypeOfEnemy.Asteroid;
            enemy.Damage = damage;
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = enemyPrefab;
            return enemy;
        }

        internal static Allien CreateAllien(Allien allienPrefab, int health, int points, int damage)
        {
            var enemy = Instantiate(allienPrefab);
            enemy.TypeOfEnemy = TypeOfEnemy.Allien;
            enemy.Points = points;
            enemy.Damage = damage;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = allienPrefab;
            return enemy;
        }

        internal static UFO CreateUFO(UFO ufoPrefab, int health, int points, int damage)
        {
            var enemy = Instantiate(ufoPrefab);
            enemy.TypeOfEnemy = TypeOfEnemy.UFO;
            enemy.Points = points;
            enemy.Damage = damage;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = ufoPrefab;
            return enemy;
        }

        internal static Ship CreateShip(Ship shipPrefab, int health, int points, int damage)
        {
            var enemy = Instantiate(shipPrefab);
            enemy.TypeOfEnemy = TypeOfEnemy.Ship;
            enemy.Points = points;
            enemy.Damage = damage;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy._enemyPrefab = shipPrefab;
            return enemy;
        }

        public static GreenShip CreateGreenShip(GreenShip greenShipPrefab, int health, int points, int damage)
        {
            var enemy = Instantiate(greenShipPrefab);
            enemy.TypeOfEnemy = TypeOfEnemy.GreenShip;
            enemy.Points = points;
            enemy.Health = new HealthOfEnemy(health, health);
            enemy.Damage = damage;
            enemy._enemyPrefab = greenShipPrefab;
            return enemy;
        }

        public Enemy Clone()
        {
            var enemy = Instantiate(_enemyPrefab);
            enemy.Points = Points;
            enemy.Health = new HealthOfEnemy(Health.MaxHealth, Health.CurrentHealth);
            enemy.OnDestroy = OnDestroy;
            enemy._enemyPrefab = _enemyPrefab;
            OnClone?.Invoke(enemy);
            return enemy;
        }

        public override string ToString()
        {
            return _typeOfEnemy.ToString();
        }

        #endregion
    }
}
