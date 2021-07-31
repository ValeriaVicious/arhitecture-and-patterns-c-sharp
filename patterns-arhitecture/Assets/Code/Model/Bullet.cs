using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Bullet
    {
        #region Properties

        public float Damage { get; private set; }
        public GameObject BulletObject { get; private set; }

        #endregion


        #region ClassLifeCycles

        public Bullet(float damage, GameObject bullet)
        {
            Damage = damage;
            BulletObject = bullet;
        }

        #endregion
    }
}
