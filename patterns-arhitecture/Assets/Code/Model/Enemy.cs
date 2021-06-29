using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal abstract class Enemy : MonoBehaviour, IExecute
    {
        #region Fields

        [SerializeField] protected float _healthOfEnemy = 5;
        [SerializeField] protected float _minSpeed = 2;
        [SerializeField] protected float _maxSpeed = 6;
        [SerializeField] protected static int _damage = 5;

        protected Rigidbody2D _rigidBody;

        #endregion

        #region Properties

        public static int Damage
        {
            get
            {
                return _damage;
            }
        }

        #endregion


        #region UnityMethods

        private void Start()
        {
            _rigidBody = GetComponent<Rigidbody2D>();
        }

        #endregion


        #region Methods

        public void Execute()
        {
            MoveTheEnemy();
        }

        public abstract void MoveTheEnemy();

        #endregion
    }
}
