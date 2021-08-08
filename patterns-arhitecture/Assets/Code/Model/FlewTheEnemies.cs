using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class FlewTheEnemies
    {
        #region Fields

        private Enemy _enemy;
        private EnemyConfig _enemyData;
        private float _theEndPointOfTheEnemyFall = 10.0f;

        #endregion


        #region ClassLifeCycles

        public FlewTheEnemies(Enemy enemy, EnemyConfig enemyConfig)
        {
            _enemy = enemy;
            _enemyData = enemyConfig;
        }

        #endregion


        #region Methods

        public void TheEnemyFlewOffTheScreen()
        {
            _enemy.GetTransform.Translate(Vector3.down * _enemyData.Speed);

            if (_enemy.transform.position.y < -_theEndPointOfTheEnemyFall && _enemy.OnEnemyOverFly != null)
            {
                _enemy.OnEnemyOverFly(_enemy.gameObject);
            }
        }

        #endregion


    }
}
