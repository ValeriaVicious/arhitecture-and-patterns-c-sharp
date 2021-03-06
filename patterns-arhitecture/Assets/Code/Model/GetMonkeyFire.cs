using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GetMonkeyFire : IShoot
    {
        #region Fields

        private readonly GameObject _bullet;
        private readonly Transform _barrelSpawner;
        private readonly float _force;
        private IViewService _pool;

        #endregion


        #region ClassLifeCycles

        public GetMonkeyFire(Rigidbody2D bullet, Transform barrel, float force,
            Sprite spriteOfBullet)
        {
            _bullet = Bullet.CreateBullet(spriteOfBullet);
            _pool = ServiceLocator.Resolve<IViewService>();
            _barrelSpawner = barrel;
            _force = force;
            _bullet.SetActive(false);
        }

        #endregion


        #region Methods

        public void GetShoot()
        {
            var temAmmunition = _pool.CreateTheObject(_bullet);
            temAmmunition.transform.position = _barrelSpawner.transform.position;

            temAmmunition.GetComponent<Rigidbody2D>().AddForce(_barrelSpawner.up * _force);
            temAmmunition.GetComponent<Bullet>().OnBecameInvisibleBullet += gameObject =>
            _pool.DestroyTheObject(gameObject, _bullet);
        }

        #endregion
    }
}
