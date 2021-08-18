using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class UIScoreInitiallization
    {
        #region Fields

        private Canvas _canvas;

        #endregion


        #region Properties

        public GameObject Score { get; private set; }

        #endregion


        #region ClassLifeCycles

        public UIScoreInitiallization(UIScoreConfig config)
        {
            _canvas = Object.FindObjectOfType<Canvas>();
        }

        #endregion
    }
}
