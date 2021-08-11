using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class Weapon : IFire
    {
        #region Fields

        private Transform _barrelPosition;
        private IAmmunition _bullet;
        private AudioClip _audioOfShot;
        private readonly AudioSource _audioSource;
        private float _force;

        #endregion


        #region ClassLifeCycles

        public Weapon(IAmmunition bullet, Transform barrelPosition,
            AudioSource audioSource, AudioClip audioClip, float force)
        {
            _bullet = bullet;
            _barrelPosition = barrelPosition;
            _audioSource = audioSource;
            _audioOfShot = audioClip;
            _force = force;
        }

        #endregion


        #region Methods

        public void SetBarrelPosition(Transform barrelPosition)
        {
            _barrelPosition = barrelPosition;
        }

        public void SetBullet(IAmmunition bullet)
        {
            _bullet = bullet;
        }

        internal void SetBarrelPosition(object barrelPositionMuffler)
        {
            throw new System.NotImplementedException();
        }

        public void SetAudioClip(AudioClip audioClip)
        {
            _audioOfShot = audioClip;
        }

        public void SetForce(float force)
        {
            _force = force;
        }

        public void Fire()
        {
            var bullet = Object.Instantiate(_bullet.BulletInstance,
                _barrelPosition.position, Quaternion.identity);
            bullet.AddForce(_barrelPosition.forward * _force);
            Object.Destroy(bullet.gameObject, _bullet.TimeToDestroy);
            _audioSource.PlayOneShot(_audioOfShot);
        }

        #endregion
    }
}
