using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "PlayerConfig", menuName = "Configs/PlayerConfig", order = 0)]
    public sealed class PlayerConfig : ScriptableObject
    {
        #region Fields

        public Player PlayerPrefab;
        public Rigidbody2D Bullet;
        public Sprite BulletSprite;
        public float PlayerSpeed;
        public float AccelerationSpeed;
        public float PlayerHP;
        public float BulletForce;
        public float ShootCoolDown;

        #endregion
    }
}