using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputAcceleration : IUserAccelerationProxy
    {
        public event Action<bool> IsAccelerationOnChange =
            delegate (bool isAcceleration) { };

        public void GetAcceleration()
        {
            IsAccelerationOnChange.Invoke(Input.GetButtonDown("Fire3"));
        }
    }
}
