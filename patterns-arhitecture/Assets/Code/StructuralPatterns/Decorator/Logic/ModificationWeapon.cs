

namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal abstract class ModificationWeapon : IFire
    {
        #region Fields

        private Weapon _weapon;

        #endregion


        #region Methods

        protected abstract Weapon AddModification(Weapon weapon);
        protected abstract void RemoveModification();

        public void ApplyModification(Weapon weapon)
        {
            _weapon = AddModification(weapon);
        }

        public void UnApplyModification(Weapon weapon)
        {
            var isApplyModification = false;
            for (int i = 0; i < weapon.WeaponModifications.Count; i++)
            {
                var modification = weapon.WeaponModifications[i];

                if (isApplyModification)
                {
                    modification.RemoveModification();
                    modification.ApplyModification(_weapon);
                }
                else if (modification.Equals(this))
                {
                    RemoveModification();
                    isApplyModification = true;
                    weapon.WeaponModifications.RemoveAt(i);
                }
            }
        }

        public void Fire()
        {
            _weapon.Fire();
        }

        #endregion
    }
}
