using System;
using UnityEngine;


namespace MVC
{
    internal sealed class PCInputVertical : IUserInput
    {
        #region Fields

        public event Action<float> AxisChange = delegate (float f) { };

        #endregion


        #region Methods

        public void GetAxis()
        {
            AxisChange.Invoke(Input.GetAxis(AxisConstants.VERTICAL));
        }

        #endregion
    }
}
