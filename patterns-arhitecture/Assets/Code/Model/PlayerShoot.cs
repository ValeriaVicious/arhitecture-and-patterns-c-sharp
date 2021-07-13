using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class PlayerShoot : IShoot
    {
        #region Fields

        private Transform _bulletSpawn;
        private Rigidbody2D _bullet;
        private float _force;

        #endregion


        #region ClassLifeCycles

        public PlayerShoot(Transform bulletSpawn, Rigidbody2D bullet, float force)
        {
            _bulletSpawn = bulletSpawn;
            _bullet = bullet;
            _force = force;
        }

        #endregion

        #region Methods

        public void GetShoot()
        {
            var temAmmunition = Object.Instantiate(_bullet, _bulletSpawn.position,
              _bulletSpawn.rotation);
            temAmmunition.AddForce(_bulletSpawn.up * _force);
        }

        #endregion
    }
}
