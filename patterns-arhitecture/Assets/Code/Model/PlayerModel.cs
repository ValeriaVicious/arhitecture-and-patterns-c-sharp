using System;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class PlayerModel
    {
        #region Fields

        public event Action DeathOfPlayer;
        public event Action<int> ChangedHealth;

        private int _maxHP = 100;
        private int _currentHP;

        #endregion


        #region ClassLifeCycles

        public PlayerModel()
        {
            _currentHP = _maxHP;
        }

        #endregion


        #region Methods

        public void SetNewHealth(int damage)
        {
            _currentHP -= damage;
            if (_currentHP > 0)
            {
                ChangedHealth?.Invoke(_currentHP);
            }
            else
            {
                DeathOfPlayer?.Invoke();
            }
        }

        #endregion
    }
}
