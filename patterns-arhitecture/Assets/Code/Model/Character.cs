

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Character : IMoveMonkeyShip
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

        #endregion

    }
}