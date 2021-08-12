using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class Enemy : MonoBehaviour
    {
        #region Fields

        private EnemyConfig _enemyData;
        public Action<GameObject> OnEnemyOverFly;
        public Action<GameObject> OnTriggerEnterChanging;

        #endregion


        #region Properties

        public Transform GetTransform => transform;
        public float Damage => _enemyData.EnemyDamage;

        #endregion


        #region Methods

        public void InitOfEnemy(EnemyConfig enemyData)
        {
            _enemyData = enemyData;
            GetComponent<SpriteRenderer>().sprite = _enemyData.MainSprite;
        }

        #endregion
    }
}
