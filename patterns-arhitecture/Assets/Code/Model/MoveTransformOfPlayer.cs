using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal class MoveTransformOfPlayer : IMoveMonkeyShip
    {
        #region Fields

        private readonly Transform _transformOfObject;
        private Vector3 _moveVector;

        #endregion


        #region Properties

        public float Speed
        {
            get; protected set;
        }

        #endregion


        #region ClassLifeCycle

        public MoveTransformOfPlayer(Transform transform, float speed)
        {
            _transformOfObject = transform;
            Speed = speed;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            var speed = deltaTime * Speed;
            _moveVector.Set(horizontal * speed, vertical * speed, 0.0f);
            _transformOfObject.localPosition += _moveVector;

            if (_transformOfObject.position.x > -CameraOfTheGame.Border)
            {
                _transformOfObject.transform.Translate(Vector3.left * speed);
            }
            if (_transformOfObject.position.x < CameraOfTheGame.Border)
            {
                _transformOfObject.transform.Translate(Vector3.right * speed);
            }
        }

        #endregion
    }
}
