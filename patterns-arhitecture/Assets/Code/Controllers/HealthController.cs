using UnityEngine;
using System;
using Object = UnityEngine.Object;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class HealthController : IInitialization, ICleanup
    {
        #region Fields

        private readonly Player _player;
        private event Action OnDeadEvent;
        private float _hp;

        #endregion


        #region ClassLifeCycles

        public HealthController(Player player, float health)
        {
            _player = player;
            _hp = health;
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
            var enemyGameObject = enemy.GetComponent<Enemy>();

            if (!enemyGameObject)
            {
                return;
            }

            if (_hp <= 0)
            {
                Object.Destroy(_player);
                OnDeadEvent?.Invoke();
            }
        }

        #endregion
    }
}