using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Character : IMoveMonkeyShip, IExecute
    {
        #region Fields

        private readonly IMoveMonkeyShip _moveImplementation;

        #endregion


        #region Properties

        public float Speed => _moveImplementation.Speed;

        #endregion


        #region ClassLifeCycle

        public Character(IMoveMonkeyShip moveImplementation)
        {
            _moveImplementation = moveImplementation;
        }

        #endregion


        #region Methods

        public void Move(float horizontal, float vertical, float deltaTime)
        {
            _moveImplementation.Move(horizontal, vertical, deltaTime);
        }

        public void AddAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.AddAcceleration();
            }
        }

        public void RemoveAcceleration()
        {
            if (_moveImplementation is AccelerationMove accelerationMove)
            {
                accelerationMove.RemoveAcceleration();
            }
        }

        public void Execute()
        {
            Debug.Log("Я курито");
        }

        #endregion

    }
}