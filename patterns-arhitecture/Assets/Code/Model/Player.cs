using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal class Player : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Transform _barrel;

        public Action<GameObject> OnCollisionEnterChange;

        #endregion


        #region Properties

        public Transform Barrel => _barrel;

        #endregion


        #region UnityMethods

        private void OnCollisionEnter2D(Collision2D collision)
        {
            OnCollisionEnterChange?.Invoke(collision.gameObject);
        }

        #endregion
    }
}
