using UnityEngine;
using System;


namespace MVC
{
    public sealed class EnemyProvider : MonoBehaviour, IEnemy
    {
        #region Fields

        [SerializeField] private float _speed;
        [SerializeField] private float _stopDistance;
        private Rigidbody2D _rigidbody;
        private Transform _transform;
        public event Action<int> OnTriggerEnterChange;

        #endregion


        #region UnityMethods

        private void Start()
        {
            _rigidbody = GetComponent<Rigidbody2D>();
            _transform = transform;
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnTriggerEnterChange?.Invoke(collision.gameObject.GetInstanceID());
        }

        #endregion


        #region Methods

        public void Move(Vector3 point)
        {
            if ((_transform.localPosition - point).sqrMagnitude >= _stopDistance * _stopDistance)
            {
                var direction = (point - _transform.localPosition).normalized;
                _rigidbody.velocity = direction * _speed;
            }
            else
            {
                _rigidbody.velocity = Vector2.zero;
            }
        }

        #endregion

    }
}