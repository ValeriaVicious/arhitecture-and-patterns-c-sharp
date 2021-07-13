using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal class Player : MonoBehaviour, IExecute
    {
        #region Fields

        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrel;
        [SerializeField] private float _force;
        [SerializeField] private float _speed;
        [SerializeField] private float _acceleration;
        [SerializeField] private int _health = 100;

        private IInput _inputController;
        private Shoot _fireInput;
        private IMoveMonkeyShip _moveTransform;
        private Character _character;
        private PlayerModel _playerModel;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _moveTransform = new AccelerationMove(transform, _speed, _acceleration);
            _character = new Character(_moveTransform);
            _inputController = new InputController(_character, _moveTransform);
            _fireInput = new GetMonkeyFire(_bullet, _barrel, _force);
            _playerModel = new PlayerModel();
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.CompareTag(Constants.EnemyTag))
            {
                _playerModel.SetNewHealth(5);
                print(collision.gameObject.name);
            }
        }

        #endregion


        #region Methods

        public void Execute()
        {
            _inputController.UserInput();
            _fireInput.UserInput();
        }

        #endregion
    }
}
