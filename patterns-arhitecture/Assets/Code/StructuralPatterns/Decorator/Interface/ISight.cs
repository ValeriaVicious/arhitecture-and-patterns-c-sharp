using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    public interface ISight
    {
        public GameObject SightInstance { get; }
        public float ForceOfSight { get; }
    }
}
