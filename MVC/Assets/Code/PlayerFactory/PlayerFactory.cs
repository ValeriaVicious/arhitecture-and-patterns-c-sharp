using UnityEngine;


namespace MVC
{
    public sealed class PlayerFactory : IPlayerFactory
    {
        #region Fields

        private readonly PlayerData _playerData;

        #endregion


        #region ClassLifeCycles

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
        }

        #endregion


        #region Methods

        public Transform CreatePlayer()
        {
            return new GameObject(Constants.PlayerTag).
                AddSprite(_playerData.Sprite).AddCircleCollider2D().
               AddCircleCollider2D().AddTrailRenderer().transform;
        }

        #endregion
    }
}
