

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ShootProxy : IShoot
    {
        #region Fields

        private readonly IShoot _shoot;
        private readonly LockedShoot _lockedShoot;

        #endregion


        #region ClassLifeCycles

        public ShootProxy(IShoot shoot, LockedShoot lockedShoot)
        {
            _shoot = shoot;
            _lockedShoot = lockedShoot;
        }

        #endregion


        #region Methods

        public void GetShoot()
        {
            if (!_lockedShoot.IsLockedWeapon)
            {
                _shoot.GetShoot();
            }
        }

        #endregion
    }
}
