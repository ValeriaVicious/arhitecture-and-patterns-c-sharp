using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class PlayerInitialization : IInitialization
    {
        #region Fields

        private Player _player;
        private IMoveMonkeyShip _movePlayer;
        private IShoot _shoot;

        #endregion


        #region Properties

        public Player Player => _player;
        public IMoveMonkeyShip Move => _movePlayer;
        public IShoot Shoot => _shoot;

        #endregion


        #region ClassLifeCycles

        public PlayerInitialization(PlayerConfig playerConfig)
        {
            _player = Object.Instantiate(playerConfig.PlayerPrefab);
            _movePlayer = new MoveTransformOfPlayer(_player.transform, playerConfig.PlayerSpeed);

            _shoot = new GetMonkeyFire(playerConfig.Bullet, _player.Barrel, playerConfig.BulletForce,
                playerConfig.BulletSprite);
        }

        #endregion


        #region Methods

        public void Initiallization()
        {
            
        }

        #endregion
    }
}
