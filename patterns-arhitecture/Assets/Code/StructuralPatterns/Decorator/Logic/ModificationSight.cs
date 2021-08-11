using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class ModificationSight : ModificationWeapon
    {
        #region Fields

        private ISight _sight;
        private Vector2 _sightPosition;
        private GameObject _sightGameObject;

        #endregion


        #region ClassLifeCycles

        public ModificationSight(ISight sight, Vector2 sightPosition)
        {
            _sight = sight;
            _sightPosition = sightPosition;
        }

        #endregion


        #region Methods

        protected override Weapon AddModification(Weapon weapon)
        {
            _sightGameObject = Object.Instantiate(_sight.SightInstance,
                _sightPosition, Quaternion.identity);
            weapon.SetForce(_sight.ForceOfSight);
            return weapon;
        }

        protected override void RemoveModification()
        {
            Object.Destroy(_sightGameObject);
        }

        #endregion
    }
}
