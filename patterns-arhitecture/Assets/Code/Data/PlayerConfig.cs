using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 0)]
    internal sealed class PlayerConfig
    {
        #region Fields

        public Player PlayerPrefab;
        public Rigidbody2D Bullet;
        public float PlayerSpeed;
        public float PlayerHP;
        public float BulletForce;

        #endregion
    }
}