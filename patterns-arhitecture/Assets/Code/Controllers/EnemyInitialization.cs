using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyInitialization : IInitialization
    {
        #region Fields

        private Enemy _enemy;
        private CompositeMoveTheEnemy _moveTheEnemy;
        private List<Enemy> _enemies;

        #endregion


        #region Properties

        public Enemy Enemy => _enemy;
        public IMoveEnemy GetMoveEnemy => _moveTheEnemy;

        #endregion


        #region ClassLifeCycles

        public EnemyInitialization(EnemyConfig enemyConfig)
        {
            _enemy = Object.Instantiate(enemyConfig.EnemyPrefab);
            _moveTheEnemy = new CompositeMoveTheEnemy();
            _enemies = new List<Enemy>();
            AddMove(_enemy, enemyConfig.Speed);
        }

        #endregion


        #region Methods

        public void Initiallization()
        {

        }
        public IMoveEnemy Move()
        {
             return _moveTheEnemy;
        }

        public IEnumerable<Enemy> GetEnemies()
        {
            foreach (var item in _enemies)
            {
                yield return item;
            }
        }

        private void AddMove(Enemy enemy, float speed)
        {
            var moveTheEnemy = new MoveTransformOfEnemy(enemy.transform, speed);
            _moveTheEnemy.AddUnit(moveTheEnemy);
        }

        #endregion
    }
}
