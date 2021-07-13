using System;
using UnityEngine;


namespace MVC
{
    internal sealed class InputInitialization : IInitialization
    {
        #region Fields

        private IUserInput _pcInputHorizontal;
        private IUserInput _pcInputVerical;

        #endregion


        #region ClassLifeCycles

        public InputInitialization()
        {
            _pcInputHorizontal = new PCInputHorizontal();
            _pcInputVerical = new PCInputVertical();
        }

        public (IUserInput inputHorizontal, IUserInput inputVertical) GetInput()
        {
            (IUserInput inputHorizontal, IUserInput inputVeetical) result =
                (_pcInputHorizontal, _pcInputVerical);
            return result;
        }

        #endregion


        #region Methods

        public void Initialization()
        {
            //throw new System.NotImplementedException();
        }

        #endregion
    }
}
