

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class MoveController : IExecute, ICleanup
    {
        #region Fields

        private readonly IMoveMonkeyShip _move;
        private IUserInputProxy _horizontalInputProxy;
        private IUserInputProxy _verticalInputProxy;
        private float _horizontal;
        private float _vertical;

        #endregion


        #region ClassLifeCycles

        public MoveController((IUserInputProxy inputHorizontal, IUserInputProxy inputVertical) input, IMoveMonkeyShip move)
        {
            _move = move;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisOnChange += HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChange += VerticalOnAxisChange;
        }

        #endregion


        #region Methods

        public void CleanUp()
        {
            _horizontalInputProxy.AxisOnChange -= HorizontalOnAxisChange;
            _verticalInputProxy.AxisOnChange -= VerticalOnAxisChange;
        }

        public void Execute(float deltaTime)
        {
            _move.Move(_horizontal, _vertical, deltaTime);
        }

        private void VerticalOnAxisChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisChange(float value)
        {
            _horizontal = value;
        }

        #endregion
    }
}