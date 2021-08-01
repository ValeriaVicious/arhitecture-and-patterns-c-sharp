using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName ="EnemiesSpawnerConfig", menuName ="Configs/EnemiesSpawnerConfig", order = 0)]
    public sealed class EnemySpawnerConfig : ScriptableObject
    {
        #region Fields

        public List<EnemyConfig> EnemyConfigs;
        public Enemy EnemyPrefab;
        public GameObject Spawner;
        public float SpawnTime;
        public int PoolCount;

        #endregion
    }
}
