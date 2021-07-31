using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class EnemiesSpawner : MonoBehaviour
    {

        #region Fields

        [SerializeField] private List<EnemyConfig> _enemySettings;
        [SerializeField] private Enemy _enemyPrefab;
        [SerializeField] private int _poolCount;
        [SerializeField] private float _spawnTime;

        private Dictionary<GameObject, Enemy> Enemies;
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
            if (_currentEnemies.Count > 0)
            {
                yield return new WaitForSeconds(_spawnTime);
                var enemy = _currentEnemies.Dequeue();
                var getEnemy = Enemies[enemy];
                enemy.SetActive(true);

                int randomEnemyObject = Random.Range(0, _enemySettings.Count);

                getEnemy.InitOfEnemy(_enemySettings[randomEnemyObject]);

                float positionx = Random.Range(-CameraOfTheGame.Border, CameraOfTheGame.Border);
                enemy.transform.position = new Vector3(positionx, transform.position.y);

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
                prefabOfEnemy.gameObject.SetActive(false);
                Enemies.Add(prefabOfEnemy.gameObject, prefabOfEnemy);
                _currentEnemies.Enqueue(prefabOfEnemy.gameObject);
                prefabOfEnemy.OnEnemyOverFly += ReturnEnemy;
            }

        }

        #endregion
    }
}
