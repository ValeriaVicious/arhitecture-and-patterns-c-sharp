using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class ExampleDecorator : MonoBehaviour
    {
        #region Fields

        [Header("Start Gun")]
        [SerializeField] private Rigidbody2D _bullet;
        [SerializeField] private Transform _barrelPosition;
        [SerializeField] private AudioClip _audioOfShot;
        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private float _timeToDestrouTheBullet = 3.0f;
        [SerializeField] private float _force = 500.0f;

        private IFire _fire;

        #endregion


        #region UnityMethods

        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, _timeToDestrouTheBullet);
            _fire = new Weapon(ammunition, _barrelPosition, _audioSource,
                _audioOfShot, _force);
        }

        private void Update()
        {
                if (Input.GetMouseButtonDown(0))
            {
                _fire.Fire();
            }
        }

        #endregion
    }
}
