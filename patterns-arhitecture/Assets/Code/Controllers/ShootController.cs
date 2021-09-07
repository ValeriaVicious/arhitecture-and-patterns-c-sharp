using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ShootController : ICleanup, IInitialization, IExecute
    {
        #region Fields

        private readonly IUserFireProxy _userFireInput;
        private readonly IShoot _shoot;
        private LockedShoot _lockedShoot;
        private Player _player;
        private float _coolDownOfShot;
        private float _shootingPauseTime = 0.0f;

        #endregion


        #region ClassLifeCycles

        public ShootController(IUserFireProxy userFireProxy, IShoot shoot,
            Player player, float coolDownShot)
        {
            _lockedShoot = new LockedShoot(false);
            _shoot = new ShootProxy(shoot, _lockedShoot);
            _coolDownOfShot = coolDownShot;
            _userFireInput = userFireProxy;
            _shoot = shoot;
            _player = player;
        }

        #endregion


        #region Methods

        private void OnCollisionPlayer(GameObject obj)
        {
            var bullet = obj.GetComponent<Bullet>();
            if (bullet)
            {
                return;
            }
            _lockedShoot.IsLockedWeapon = true;
        }

        public void CleanUp()
        {
            _userFireInput.FireInputGetDown -= OnFire;
            _player.OnCollisionEnterChange -= OnCollisionPlayer;
        }

        public void Initiallization()
        {
            _userFireInput.FireInputGetDown += OnFire;
            _player.OnCollisionEnterChange += OnCollisionPlayer;
        }

        private void OnFire(bool isShoot)
        {
            if (isShoot)
            {
                _shoot.GetShoot();
            }
        }

        public void Execute(float deltaTime)
        {
            _shootingPauseTime += deltaTime;
            if (!_lockedShoot.IsLockedWeapon)
            {
                return;
            }

            if (_shootingPauseTime > _coolDownOfShot)
            {
                _lockedShoot.IsLockedWeapon = false;
                _shootingPauseTime = 0.0f;
            }
        }

        #endregion
    }
}