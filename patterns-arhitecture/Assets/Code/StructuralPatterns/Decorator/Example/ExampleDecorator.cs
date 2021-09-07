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

        [Header("MufflerGun")]
        [SerializeField] private AudioClip _audioClipOfMuffler;
        [SerializeField] private Transform _barrelPositionOfMuffler;
        [SerializeField] private GameObject _muffler;
        [SerializeField] private float _volumeFireOnMuffler;

        [Header("Sight")]
        [SerializeField] private Transform _sightPosition;
        [SerializeField] private GameObject _sight;
        [SerializeField] private float _forceOfSight;

        private IFire _fire;

        #endregion


        #region UnityMethods

        private void Start()
        {
            IAmmunition ammunition = new Bullet(_bullet, _timeToDestrouTheBullet);

            var weapon = new Weapon(ammunition, _barrelPosition, _audioSource,
                _audioOfShot, _force);
            var muffler = new Muffler(_muffler, _audioClipOfMuffler, _barrelPositionOfMuffler,
                _volumeFireOnMuffler);
            var sight = new Sight(_sight, _sightPosition, _forceOfSight);

            ModificationWeapon modificationWeaponMuffler = new ModificationMuffler(_audioSource, muffler,
                _barrelPositionOfMuffler.position);
            modificationWeaponMuffler.ApplyModification(weapon);

            ModificationWeapon modificationWeaponSight = new ModificationSight(sight, _sightPosition.position);
            modificationWeaponSight.ApplyModification(weapon);

            _fire = modificationWeaponMuffler;
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
