

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class LockedShoot
    {
        #region Properties

        public bool IsLockedWeapon { get; set; }

        #endregion


        #region ClassLifeCycles

        public LockedShoot(bool isLockedWeapon)
        {
            IsLockedWeapon = isLockedWeapon;
        }

        #endregion
    }
}
