using System;


namespace MonkeyInTheSpace.GeekBrains
{
    [Serializable]
    public sealed class HealthOfEnemy
    {
        #region Properties

        public int MaxHealth { get; }
        public int CurrentHealth { get; private set; }

        #endregion


        #region ClassLifeCycles

        public HealthOfEnemy(int maxHealth, int currentHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
        }

        #endregion


        #region Methods

        public void ChangeCurrentHealth(int hp)
        {
            CurrentHealth = hp;
        }

        #endregion
    }
}