using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class InputVertical : IUserInputProxy
    {
        #region Fields

        public event Action<float> AxisOnChange = 
            delegate (float changeOfDirection) { };

        #endregion


        #region Methods

        public void GetAxis()
        {
            AxisOnChange.Invoke(Input.GetAxis(AxisConstants.VerticalInput));
        }

        #endregion
    }
}
