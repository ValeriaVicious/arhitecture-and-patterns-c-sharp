using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class EnemyMoveController : IExecute
    {
        #region Fields

        private readonly IMoveEnemy _moveEnemy;
        private Vector2 _direction;

        #endregion


        #region ClassLifeCycles

        public EnemyMoveController(IMoveEnemy moveEnemy)
        {
            _moveEnemy = moveEnemy;
            _direction = new Vector2(0.0f, -1.0f);
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _moveEnemy.TheEnemyMove(_direction.x, _direction.y, deltaTime);
        }

        #endregion
    }
}
