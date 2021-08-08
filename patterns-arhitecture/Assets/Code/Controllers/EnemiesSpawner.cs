using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class EnemiesSpawner : IFixedExecute
    {

        #region Fields

        private EnemySpawnerConfig _enemySpawnConfigs;
        private Dictionary<GameObject, Enemy> _enemies;
        private Queue<GameObject> _currentEnemies;
        private Enemy _enemy;
        private EnemyConfig _enemyConfig;
        private FlewTheEnemies _flewTheEnemies;

        #endregion


        #region ClassLifeCycles

        public EnemiesSpawner(EnemySpawnerConfig enemySpawnerConfig, Enemy enemyPrefab, EnemyConfig enemyConfig)
        {
            _enemy = enemyPrefab.gameObject.GetComponent<Enemy>();
            _enemyConfig = enemyConfig;
            _flewTheEnemies = new FlewTheEnemies(_enemy, _enemyConfig);

            _enemySpawnConfigs = enemySpawnerConfig;
            _enemies = new Dictionary<GameObject, Enemy>();
            _currentEnemies = new Queue<GameObject>();
            CreateAndGetAndLoadToThePoolObjects();
            Spawn().StartCoroutine(out _);
        }

        #endregion


        #region Methods

        private IEnumerator Spawn()
        {
            if (_enemySpawnConfigs.SpawnTime == 0)
            {
                _enemySpawnConfigs.SpawnTime = 1;
            }

            while (true)
            {
                if (_currentEnemies.Count > 0)
                {
                    yield return new WaitForSeconds(_enemySpawnConfigs.SpawnTime);
                    var enemy = _currentEnemies.Dequeue();
                    var getEnemy = _enemies[enemy];
                    enemy.SetActive(true);

                    int randomEnemyObject = Random.Range(0, _enemySpawnConfigs.EnemyConfigs.Count);

                    getEnemy.InitOfEnemy(_enemySpawnConfigs.EnemyConfigs[randomEnemyObject]);

                    float positionX = Random.Range(-CameraOfTheGame.Border, CameraOfTheGame.Border);
                    enemy.transform.position = new Vector3(positionX, _enemySpawnConfigs.Spawner.transform.position.y);

                }
            }

        }

        private void ReturnEnemy(GameObject enemy)
        {
            enemy.transform.position = _enemySpawnConfigs.Spawner.transform.position;
            enemy.SetActive(false);
            _currentEnemies.Enqueue(enemy);
        }

        private void CreateAndGetAndLoadToThePoolObjects()
        {
            for (int i = 0; i < _enemySpawnConfigs.PoolCount; ++i)
            {
                var prefabOfEnemy = Object.Instantiate(_enemySpawnConfigs.EnemyPrefab);
                prefabOfEnemy.gameObject.SetActive(false);
                _enemies.Add(prefabOfEnemy.gameObject, prefabOfEnemy);
                _currentEnemies.Enqueue(prefabOfEnemy.gameObject);
                prefabOfEnemy.OnEnemyOverFly += ReturnEnemy;
            }
        }

        public void FixedExecute(float deltaTime)
        {
            _flewTheEnemies.TheEnemyFlewOffTheScreen();
        }

        #endregion
    }
}
