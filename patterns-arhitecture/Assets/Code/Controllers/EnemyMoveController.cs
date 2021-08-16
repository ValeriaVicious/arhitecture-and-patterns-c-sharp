using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyMoveController : IFixedExecute
    {
        #region Fields

        private readonly IMoveEnemy _moveEnemy;

        #endregion


        #region ClassLifeCycles

        public EnemyMoveController(IMoveEnemy moveEnemy)
        {
            _moveEnemy = moveEnemy;
        }

        #endregion


        #region Methods

        public void FixedExecute(float deltaTime)
        {
            _moveEnemy.TheEnemyMove();
        }

        #endregion
    }
}
