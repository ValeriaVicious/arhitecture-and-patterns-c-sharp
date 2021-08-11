

namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal abstract class ModificationWeapon : IFire
    {
        #region Fields

        private Weapon _weapon;

        #endregion


        #region Methods

        protected abstract Weapon AddModification(Weapon weapon);

        public void ApplyModification(Weapon weapon)
        {
            _weapon = AddModification(weapon);
        }

        public void Fire()
        {
            _weapon.Fire();
        }

        #endregion
    }
}
