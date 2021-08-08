using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "EnemyConfig", menuName = "Configs/EnemyConfig", order = 0)]
    public sealed class EnemyConfig : ScriptableObject
    {
        #region Fields

        [SerializeField] private Enemy _enemyPrefab;
        [SerializeField] private Sprite _mainSprite;
        [SerializeField] private float _speedOfEnemy;
        [SerializeField] private int _damageOfEnemy;

        #endregion


        #region Properties

        public Sprite MainSprite => _mainSprite;

        public Enemy EnemyPrefab => _enemyPrefab;

        public float Speed => _speedOfEnemy;


        public int EnemyDamage => _damageOfEnemy;

        #endregion
    }
}
