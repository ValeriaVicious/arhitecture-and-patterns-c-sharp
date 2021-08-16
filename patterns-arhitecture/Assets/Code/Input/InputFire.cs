using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputFire : IUserFireProxy
    {
        #region Fields

        public event Action<bool> FireInputGetDown =
            delegate (bool isFireGetDown) { };

        #endregion


        #region Methods

        public void GetFireDown()
        {
            FireInputGetDown.Invoke(Input.GetButtonDown(Constants.FireInput));
        }

        #endregion
    }
}
