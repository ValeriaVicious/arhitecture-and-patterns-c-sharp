using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class EnemiesSpawner : MonoBehaviour
    {

        #region Fields

        [SerializeField] private static Dictionary<GameObject, Enemy> Enemies;
        [SerializeField] private List<EnemyConfig> _enemySettings;
        [SerializeField] private GameObject _enemyPrefab;
        [SerializeField] private int _poolCount;
        [SerializeField] private float _spawnTime;

        private Queue<GameObject> _currentEnemies;

        #endregion


        #region UnityMethods

        private void Start()
        {
            CreateAndGetAndLoadToThePoolObjects();
            StartCoroutine(Spawn());
        }

        #endregion


        #region Methods

        private IEnumerator Spawn()
        {
            if (_spawnTime == 0)
            {
                _spawnTime = 1;
            }
            while (true)
            {
                yield return new WaitForSeconds(_spawnTime);
                if (_currentEnemies.Count > 0)
                {
                    var enemy = _currentEnemies.Dequeue();
                    var getEnemyComponent = Enemies[enemy];
                    enemy.SetActive(true);

                    int randomEnemyObject = Random.Range(0, _enemySettings.Count);

                    getEnemyComponent.InitOfEnemy(_enemySettings[randomEnemyObject]);

                    float positionx = Random.Range(-CameraOfTheGame.Border, CameraOfTheGame.Border);
                    enemy.transform.position = new Vector3(positionx, transform.position.y);

                }
            }
        }

        private void ReturnEnemy(GameObject enemy)
        {
            enemy.transform.position = transform.position;
            enemy.SetActive(false);
            _currentEnemies.Enqueue(enemy);
        }

        private void CreateAndGetAndLoadToThePoolObjects()
        {
            Enemies = new Dictionary<GameObject, Enemy>();
            _currentEnemies = new Queue<GameObject>();

            for (int i = 0; i < _poolCount; ++i)
            {
                var prefabOfEnemy = Instantiate(_enemyPrefab);
                var getEnemyComponent = prefabOfEnemy.GetComponent<Enemy>();
                prefabOfEnemy.SetActive(false);
                Enemies.Add(prefabOfEnemy, getEnemyComponent);
                _currentEnemies.Enqueue(prefabOfEnemy);
            }
            Enemy.OnEnemyOverFly += ReturnEnemy;
        }

        #endregion
    }
}
