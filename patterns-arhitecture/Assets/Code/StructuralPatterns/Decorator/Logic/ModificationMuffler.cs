using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class ModificationMuffler : ModificationWeapon
    {
        #region Fields

        private readonly AudioSource _audioSource;
        private readonly IMuffler _muffler;
        private readonly Vector2 _mufflerPosition;

        #endregion


        #region ClassLifeCycles

        public ModificationMuffler(AudioSource audioSource, IMuffler muffler,
            Vector2 mufflerPosition)
        {
            _audioSource = audioSource;
            _muffler = muffler;
            _mufflerPosition = mufflerPosition;
        }

        #endregion


        #region Methods

        protected override Weapon AddModification(Weapon weapon)
        {
            var muffler = Object.Instantiate(_muffler.MufflerInstance,
                _mufflerPosition, Quaternion.identity);
            _audioSource.volume = _muffler.VolumeFireOnMuffler;
            weapon.SetAudioClip(_muffler.AudioClipMuffler);
            weapon.SetBarrelPosition(_muffler.BarrelPositionMuffler);
            return weapon;
        }

        #endregion
    }
}
