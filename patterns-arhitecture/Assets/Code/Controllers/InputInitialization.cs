

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputInitialization : IInitialization
    {
        #region Fields

        private IUserInputProxy _verticalInput;
        private IUserInputProxy _horizontalInput;
        private IUserFireProxy _fireInput;

        #endregion


        #region ClassLifeCycles

        public InputInitialization()
        {
            _horizontalInput = new InputHorizontal();
            _fireInput = new InputFire();
            _verticalInput = new InputVertical();
        }

        #endregion


        #region Methods

        public void Initiallization()
        {

        }

        public (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) GetInput()
        {
            (IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) result = (_horizontalInput, _verticalInput);
            return result;
        }

        public IUserFireProxy GetFire()
        {
            return _fireInput;
        }

        #endregion
    }
}