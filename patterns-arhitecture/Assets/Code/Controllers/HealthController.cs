
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class HealthController : IInitialization, ICleanup
    {
        #region Fields

        private float _health;
        private Player _player;

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
            if (_health <= 0)
            {
                Object.Destroy(_player);
            }
            else
            {
                _health--;
            }
        }

        #endregion
    }
}