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

        private void OnBecameInvisible()
        {
            OnBecameInvisibleBullet?.Invoke(gameObject);
        }

        #endregion
    }
}
