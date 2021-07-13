using UnityEngine;


namespace MVC
{
    internal sealed class PlayerInitialization : IInitialization
    {
        #region Fields

        private readonly IPlayerFactory _playerFactory;
        private Transform _player;

        #endregion


        #region ClassLifeCycles

        public PlayerInitialization(IPlayerFactory playerFactory, Vector2 positionOfPlayer)
        {
            _playerFactory = playerFactory;
            _player = _playerFactory.CreatePlayer();
            _player.position = positionOfPlayer;
        }

        #endregion


        #region Methods

        public void Initialization()
        {
            
        }

        public Transform GetPlayer()
        {
            return _player;
        }

        #endregion
    }
}
