
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class HealthController : IInitialization, ICleanup
    {
        #region Fields

        private readonly Player _player;
        private PlayerConfig _playerConfig;

        #endregion


        #region ClassLifeCycles

        public HealthController(Player player)
        {
            _player = player;
        }

        #endregion


        #region Methods

        public void CleanUp()
        {
            _player.OnCollisionEnterChange -= OnCollisionPlayer;
        }

        public void Initiallization()
        {
            _player.OnCollisionEnterChange += OnCollisionPlayer;
        }

        private void OnCollisionPlayer(GameObject enemy)
        {
            if (_playerConfig.PlayerHP <= 0)
            {
                Object.Destroy(_player);
            }
            else
            {
                _playerConfig.PlayerHP--;
            }
        }

        #endregion
    }
}