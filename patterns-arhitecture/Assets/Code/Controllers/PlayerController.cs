using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class PlayerController
    {
        #region Fields

        private readonly PlayerView _playerView;
        private readonly PlayerModel _playerModel;

        #endregion


        #region ClassLifeCycles

        public PlayerController(PlayerView playerView, PlayerModel playerModel)
        {
            _playerView = playerView;
            _playerModel = playerModel;
        }

        #endregion


        #region Methods

        public void Enable()
        {
            _playerModel.DeathOfPlayer += Death;
        }

        public void ChangeHealth(int health)
        {
            _playerView.ChangeHealth(health);
            Debug.Log(health);
        }

        public void Disable()
        {
            _playerModel.DeathOfPlayer -= Death;
            _playerModel.ChangedHealth -= ChangeHealth;
        }

        private void Death()
        {
            _playerView.Death();
            Disable();
        }

        #endregion
    }
}
