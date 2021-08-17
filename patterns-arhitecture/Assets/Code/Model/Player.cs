using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public class Player : MonoBehaviour
    {
        #region Fields

        [SerializeField] private Transform _barrel;

        public Action<GameObject> OnCollisionEnterChange;

        #endregion


        #region Properties

        public Transform Barrel => _barrel;

        #endregion


        #region UnityMethods

        private void OnTriggerEnter2D(Collider2D collision)
        {
            OnCollisionEnterChange?.Invoke(collision.gameObject);
            print(collision.gameObject.name);
        }

        #endregion
    }
}
