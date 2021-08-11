using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class Muffler : IMuffler
    {
        #region Properties

        public GameObject MufflerInstance { get; }

        public float VolumeFireOnMuffler { get; }

        public AudioClip AudioClipMuffler { get; }

        public Transform BarrelPositionMuffler { get; }

        #endregion


        #region ClassLifeCycles

        public Muffler(GameObject mufflerInstance, AudioClip audioClip, 
            Transform barrelPositionMuffler, float volumeFireOnMuffler)
        {
            MufflerInstance = mufflerInstance;
            AudioClipMuffler = audioClip;
            BarrelPositionMuffler = barrelPositionMuffler;
            VolumeFireOnMuffler = volumeFireOnMuffler;
        }

        #endregion
    }
}
