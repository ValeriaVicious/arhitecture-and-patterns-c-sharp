using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class Bullet : IAmmunition
    {
        #region Properties

        public Rigidbody2D BulletInstance { get; }

        public float TimeToDestroy { get; }

        #endregion


        #region ClassLifeCycles

        public Bullet(Rigidbody2D bulletInstance, float timeToDestroy)
        {
            BulletInstance = bulletInstance;
            TimeToDestroy = timeToDestroy;
        }

        #endregion
    }
}
