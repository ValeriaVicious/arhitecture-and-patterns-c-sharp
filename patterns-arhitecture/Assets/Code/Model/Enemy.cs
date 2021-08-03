using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class Enemy : MonoBehaviour
    {
        #region Fields

        public Action<GameObject> OnEnemyOverFly;
        public Action<GameObject> OnTriggerEnterChanging;

        #endregion

        #region Properties

        public Transform GetTransform => transform;

        #endregion
 
    }
}
