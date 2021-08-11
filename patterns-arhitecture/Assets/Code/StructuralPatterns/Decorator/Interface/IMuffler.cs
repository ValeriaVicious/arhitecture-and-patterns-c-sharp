using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal interface IMuffler
    {
        public GameObject MufflerInstance { get; }
        public float VolumeFireOnMuffler { get; }
        public AudioClip AudioClipMuffler { get; }
        public Transform BarrelPositionMuffler { get; }
    }
}