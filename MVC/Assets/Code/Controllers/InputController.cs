

namespace MVC
{
    internal sealed class InputController : IExecute
    {
        #region Fields

        private readonly IUserInput _horizontal;
        private readonly IUserInput _vertical;

        #endregion


        #region ClassLifeCycles

        public InputController((IUserInput inputHorizontal, IUserInput inputVertical)input)
        {
            _horizontal = input.inputHorizontal;
            _vertical = input.inputVertical;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _horizontal.GetAxis();
            _vertical.GetAxis();
        }

        #endregion
    }
}
