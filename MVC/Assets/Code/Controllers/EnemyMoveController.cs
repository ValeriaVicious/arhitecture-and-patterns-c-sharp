using UnityEngine;

namespace MVC
{
    internal class EnemyMoveController : IController
    {
        #region Fields

        private readonly IMove _move;
        private readonly Transform _transform;

        #endregion


        #region ClassLifeCycles

        public EnemyMoveController(IMove move, Transform transform)
        {
            _move = move;
            _transform = transform;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _move.Move(_transform.localPosition);
        }

        #endregion
    }
}