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
            _barrelSpawner = barrel;
            _force = force;
            _pool = new ViewViewServices();
        }

        #endregion


        #region Methods

        public void GetShoot()
        {
           var temAmmunition = _pool.CreateTheObject(_bullet);
        }

        #endregion
    }
}
