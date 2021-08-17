using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/EnemyConfig", order = 0)]
    public sealed class EnemyConfig : ScriptableObject
    {
        #region Fields

        [SerializeField] private List<InfoOfEnemy> _infoOfEnemies;

        public List<InfoOfEnemy> Enemies => _infoOfEnemies;

        #endregion


        #region Methods

        public (Enemy enemy, int health, int points) GetEnemy(TypeOfEnemy typeOfEnemy)
        {
            var enemyInfo = _infoOfEnemies.First(info => info.TypeOfEnemy == typeOfEnemy);
            return (enemyInfo.EnemyPrefab, enemyInfo.Health, enemyInfo.Points);
        }

        #endregion
    }

    [Serializable]
    public sealed class InfoOfEnemy
    {
        public Enemy EnemyPrefab;
        public TypeOfEnemy TypeOfEnemy;
        public Transform SpawnPosition;
        public float Speed;
        public int Points = 1;
        public int Health;
    }
}
