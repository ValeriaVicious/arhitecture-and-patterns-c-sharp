using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyInitialization : IInitialization
    {
        #region Fields

        private IEnemyFactory _enemyFactory;
        private CompositeMoveTheEnemy _moveTheEnemy;
        private List<Enemy> _enemies;

        #endregion


        #region ClassLifeCycles

        public EnemyInitialization(EnemyConfig enemyConfig)
        {
            _enemyFactory = new EnemyFactory(enemyConfig);
            _moveTheEnemy = new CompositeMoveTheEnemy();
            _enemies = new List<Enemy>();
            foreach (var item in enemyConfig.Enemies)
            {
                var enemy = (Enemy)_enemyFactory.CreateEnemy(item.TypeOfEnemy);
                AddMove(enemy, item.Speed);
                _enemies.Add(enemy);
            }
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
            IMoveEnemy moveTheEnemy = new MoveTransformOfEnemy(enemy.transform, speed);
            _moveTheEnemy.AddUnit(moveTheEnemy);
            enemy.OnClone += enemyClone =>
            {
                _moveTheEnemy.RemoveUnit(moveTheEnemy);
                AddMove(enemyClone, speed);
                _enemies.Add(enemyClone);
            };
        }

        #endregion
    }
}
