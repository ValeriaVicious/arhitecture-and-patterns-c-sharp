using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class UIInitiallization
    {
        #region Fields

        private Canvas _canvas;

        #endregion


        #region Properties

        public GameObject Score { get; private set; }
        public GameObject DestroyedEnemy;

        #endregion


        #region ClassLifeCycles

        public UIInitiallization(UIScoreConfig config)
        {
            _canvas = Object.FindObjectOfType<Canvas>();
            Score = Object.Instantiate(config.Score, _canvas.transform);
            DestroyedEnemy = Object.Instantiate(config.DestroyedEnemies, _canvas.transform);
        }

        #endregion
    }
}
