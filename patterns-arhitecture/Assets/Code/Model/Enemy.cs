using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class Enemy : MonoBehaviour
    {
        #region Fields

        private EnemyConfig _enemyData;
        private static float _theEndPointOfTheEnemyFall = 10.0f;

        public Action<GameObject> OnEnemyOverFly;
        public Action<GameObject> OnTriggerEnterChanging;

        #endregion

        #region Properties

        public int Damage => _enemyData.EnemyDamage;
        public static float EndPointOfTheEnemyFall => _theEndPointOfTheEnemyFall;

        public Transform GetTransform => transform;

        #endregion


        #region UnityMethods

        private void FixedUpdate()
        {
            TheEnemyFlewOffTheScreen();
        }

        #endregion


        #region Methods

        private void TheEnemyFlewOffTheScreen()
        {
            transform.Translate(Vector3.down * _enemyData.Speed);
            if (transform.position.y < -_theEndPointOfTheEnemyFall && OnEnemyOverFly != null)
            {
                OnEnemyOverFly(gameObject);
            }
        }

        public void InitOfEnemy(EnemyConfig enemyData)
        {
            _enemyData = enemyData;
            GetComponent<SpriteRenderer>().sprite = _enemyData.MainSprite;
        }

        #endregion
    }
}
