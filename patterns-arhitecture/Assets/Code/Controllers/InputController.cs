using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputController : IExecute
    {
        #region Fields

        private readonly IUserInputProxy _inputHorizontal;
        private readonly IUserInputProxy _inputVertical;
        private readonly IUserFireProxy _inputFire;

        #endregion


        #region ClassLifeCycles

        public InputController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input, IUserFireProxy inputFire)
        {
            _inputHorizontal = input.inputHorizontal;
            _inputVertical = input.inputVertical;
            _inputFire = inputFire;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _inputHorizontal.GetAxis();
            _inputVertical.GetAxis();
            _inputFire.GetFireDown();
        }

        #endregion
    }
}
