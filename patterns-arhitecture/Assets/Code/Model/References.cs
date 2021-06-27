

using UnityEngine;

namespace MonkeyInTheSpace.GeekBrains
{
    internal class References
    {
        #region Fields

        private Player _playerMonkey;

        #endregion


        #region Properties

        public Player PlayerMonkey
        {
            get
            {
                if (_playerMonkey == null)
                {
                    var gameObjectPlayer = Resources.Load<Player>(Constants.CharacterResourcesPath);
                    _playerMonkey = Object.Instantiate(gameObjectPlayer);
                }
                return _playerMonkey;
            }

        }

        #endregion
    }
}