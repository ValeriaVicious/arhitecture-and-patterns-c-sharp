using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GetMonkeyFire : IFireInput
    {
        #region Fields

        private readonly Rigidbody2D _bullet;
        private readonly Transform _barrel;
        private readonly float _force;

        #endregion


        #region ClassLifeCycles

        public GetMonkeyFire(Rigidbody2D bullet, Transform barrel, float force)
        {
            _bullet = bullet;
            _barrel = barrel;
            _force = force;
        }

        #endregion


        #region Methods

        public void GetFire()
        {
            var temAmmunition = Object.Instantiate(_bullet, _barrel.position, _barrel.rotation);
            temAmmunition.AddForce(_barrel.up * _force);
        }

        public void UserInput()
        {
            if (Input.GetButtonDown(Constants.FireInput))
            {
                GetFire();
            }
        }

        #endregion
    }
}
