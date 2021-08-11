using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal interface IAmmunition
    {
        public Rigidbody2D BulletInstance { get; }
        public float TimeToDestroy { get; }
    }
}