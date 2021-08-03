using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class AccelerationController : IExecute, ICleanup
    {
        #region Fields

        private PlayerConfig _playerData;
        private IUserAccelerationProxy _acecelerationProxy;

        #endregion


        #region ClassLifeCycles

        public AccelerationController(IUserAccelerationProxy acecelerationProxy)
        {
            _acecelerationProxy = acecelerationProxy;
            _acecelerationProxy.IsAccelerationOnChange += AccelerationOnChange;
        }

        #endregion


        #region Methods

        public void Execute(float deltaTime)
        {
            _acecelerationProxy.GetAcceleration();
        }

        public void CleanUp()
        {
            _acecelerationProxy.IsAccelerationOnChange -= AccelerationOnChange;
        }

        private void AccelerationOnChange(bool isAcceleration)
        {
            _playerData.PlayerSpeed += _playerData.AccelerationSpeed;
        }

        #endregion
    }
}
