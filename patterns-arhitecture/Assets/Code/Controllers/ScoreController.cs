using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class ScoreController : ICleanup
    {
        #region Fields

        private TextScoreOnDisplay _displayScore;
        private int _points = 0;

        #endregion


        #region ClassLifeCycles

        public ScoreController(GameObject scoreTextObject)
        {
            _displayScore = new TextScoreOnDisplay(scoreTextObject);
            MessageBroker.Subscribe<EnemyDestroyMessage>(OnEnemyDestroy);
        }

        #endregion


        #region Methods

        private void OnEnemyDestroy(EnemyDestroyMessage enemyDestroyMessage)
        {
            _points += enemyDestroyMessage.Points;
            _displayScore.Display(_points);
        }

        public void CleanUp()
        {
            MessageBroker.Unsubscribe<EnemyDestroyMessage>(OnEnemyDestroy);
        }

        #endregion
    }
}
