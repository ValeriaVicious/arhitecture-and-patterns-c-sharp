using UnityEngine;
using System;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Bullet : MonoBehaviour
    {
        #region Fields

        public event Action<GameObject> OnBecameInvisibleBullet;

        private static float _massOfBody = 1.0f;
        private static float _radiusOfCollider = 0.25f;
        private static bool _isTriggerOfCollider = true;

        #endregion


        #region Methods

        internal static GameObject CreateBullet(Sprite sprite)
        {
            var bullet = new GameObject(Constants.BulletTag);
            bullet.AddSpriteToTheObject(sprite);
            bullet.AddCircleCollider2DToTheObject(_radiusOfCollider, _isTriggerOfCollider);
            bullet.AddRigidBody2DToTheObject(_massOfBody);
            bullet.AddComponent<Bullet>();
            return bullet;
        }

        private void OnBecameInvisible()
        {
            OnBecameInvisibleBullet?.Invoke(gameObject);
        }

        #endregion
    }
}
