using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputFire : IUserFireProxy
    {
        public event Action<bool> FireInputGetDown =
            delegate (bool isFireGetDown) { };

        public void GetFireDown()
        {
            FireInputGetDown.Invoke(Input.GetButtonDown(Constants.FireInput));
        }
    }
}
