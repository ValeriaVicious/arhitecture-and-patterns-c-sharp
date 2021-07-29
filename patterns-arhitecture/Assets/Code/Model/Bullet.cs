using UnityEngine;
using System;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Bullet : MonoBehaviour
    {
        #region Fields

        public event Action<GameObject> OnBecameInvisibleBullet;

        #endregion


        #region Methods

        internal static GameObject CreateBullet(Sprite sprite)
        {
            var bullet = new GameObject(TagsConstants.BulletTag);
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
