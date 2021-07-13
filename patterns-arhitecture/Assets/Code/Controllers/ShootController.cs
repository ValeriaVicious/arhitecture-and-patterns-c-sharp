using System;

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ShootController : ICleanup
    {
        #region Fields

        private readonly IUserFireProxy _userFireInput;
        private readonly IShoot _shoot;

        #endregion


        #region ClassLifeCycles

        public ShootController(IUserFireProxy userFireProxy, IShoot shoot)
        {
            _userFireInput = userFireProxy;
            _shoot = shoot;
            _userFireInput.FireInputGetDown += OnFire;
        }

        #endregion


        #region Methods

        public void CleanUp()
        {
            _userFireInput.FireInputGetDown -= OnFire;
        }

        private void OnFire(bool isShoot)
        {
            if (isShoot)
            {
                _shoot.GetShoot();
            }
        }

        #endregion
    }
}