using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class MoveTransformOfEnemy : IMoveEnemy
    {
        #region Fields

        private readonly Transform _transformOfEnemy;

        #endregion


        #region Properties

        public float Speed { get; set; }

        #endregion


        #region ClassLifeCycles

        public MoveTransformOfEnemy(Transform transform, float speed)
        {
            _transformOfEnemy = transform;
            Speed = speed;
        }

        #endregion


        #region Methods

        public void TheEnemyMove(float horizontal, float vertical, float deltaTime)
        {
            _transformOfEnemy.Translate(Vector3.down * Speed);
        }

        #endregion
    }
}
