using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Enemy : MonoBehaviour, IExecute
    {
        #region Fields

        private EnemyConfig _enemyData;
        private float _theEndPointOfTheEnemyFall = 10.0f;

        public static Action<GameObject> OnEnemyOverFly;

        #endregion

        #region Properties

        public int Damage => _enemyData.EnemyDamage;

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

        public void Execute(float deltaTime)
        {
            TheEnemyFlewOffTheScreen();
        }

        #endregion
    }
}
