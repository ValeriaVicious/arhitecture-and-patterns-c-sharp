using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputController : IInput
    {
        #region Fields

        private readonly Character _character;
        private readonly IMoveMonkeyShip _moveTransform;

        #endregion


        #region ClassLifeCycles

        public InputController(Character character, IMoveMonkeyShip move)
        {
            _character = character;
            _moveTransform = move;
        }

        #endregion


        #region Methods

        public void UserInput()
        {
            _moveTransform.Move(Input.GetAxis(Constants.HorizontalInput),
                Input.GetAxis(Constants.VerticalInput), Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                _character.AddAcceleration();
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                _character.RemoveAcceleration();
            }
        }

        #endregion
    }
}
