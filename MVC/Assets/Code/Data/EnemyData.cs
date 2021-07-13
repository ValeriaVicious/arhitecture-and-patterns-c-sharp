using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace MVC
{
    [CreateAssetMenu(fileName ="EnemySettings", menuName ="Data/Unit/ENemySettings")]
    public sealed class EnemyData : ScriptableObject
    {
        #region Fields

        [Serializable] private struct EnemyInfo
        {
            public EnemyType EnemyType;
            public EnemyProvider EnemyPrefab;
        }

        [SerializeField] private List<EnemyInfo> _enemyInfos;

        #endregion


        #region Methods

        public EnemyProvider GetEnemy(EnemyType type)
        {
            var enemyInfo = _enemyInfos.First(info => info.EnemyType == type);
            return enemyInfo.EnemyPrefab;
        }

        #endregion
    }
}