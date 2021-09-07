using System;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyFactory : IEnemyFactory
    {
        #region Fields

        private readonly EnemyConfig _enemiesData;

        #endregion


        #region ClassLifeCycles

        public EnemyFactory(EnemyConfig enemyConfig)
        {
            _enemiesData = enemyConfig;
        }

        #endregion


        #region Methods

        public IEnemy CreateEnemy(TypeOfEnemy enemyType)
        {
            var (enemy, health, points, damage) = _enemiesData.GetEnemy(enemyType);

            return enemyType switch
            {
                TypeOfEnemy.Asteroid => Enemy.CreateAsteroid((Asteroid)enemy, health, points, damage),
                TypeOfEnemy.GreenShip => Enemy.CreateGreenShip((GreenShip)enemy, health, points, damage),
                TypeOfEnemy.Allien => Enemy.CreateAllien((Allien)enemy, health, points, damage),
                TypeOfEnemy.Ship => Enemy.CreateShip((Ship)enemy, health, points, damage),
                TypeOfEnemy.UFO => Enemy.CreateUFO((UFO)enemy, health, points, damage),
                _ => throw new ArgumentOutOfRangeException(nameof(enemyType), enemyType, null)
            };
        }

        #endregion
    }
}
