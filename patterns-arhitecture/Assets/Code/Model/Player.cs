using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Player : MonoBehaviour, IExecute
    {
        #region Fields

        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;

        private IInput _inputController;
        private IMoveMonkeyShip _moveTransform;
        private Character _character;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            _character = new Character(_moveTransform);
            _inputController = new InputController(_character, _moveTransform);
        }

        #endregion


        #region Methods

        public void Execute()
        {
            _inputController.UserInput();
        }

        #endregion
    }
}
