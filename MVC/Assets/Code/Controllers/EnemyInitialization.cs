using System.Collections.Generic;


namespace MVC
{
    internal sealed class EnemyInitialization : IInitialization
    {
        #region Fields

        private readonly IEnemyFactory _enemyFactory;
        private CompositeMove _enemyMove;
        private List<IEnemy> _enemies;

        #endregion


        #region ClassLifeCycles

        public EnemyInitialization(IEnemyFactory enemyFactory)
        {
            _enemyFactory = enemyFactory;
            _enemyMove = new CompositeMove();
            var enemy = _enemyFactory.CreateEnemy(EnemyType.Small);
            _enemies = new List<IEnemy> { enemy };
        }

        #endregion


        #region Methods

        public void Initialization()
        {
            
        }

        public IMove GetMoveEnemies()
        {
            return _enemyMove;
        }

        public IEnumerable<IEnemy> GetEnemies()
        {
            foreach (var item in _enemies)
            {
                yield return item;
            }
        }

        #endregion
    }
}
