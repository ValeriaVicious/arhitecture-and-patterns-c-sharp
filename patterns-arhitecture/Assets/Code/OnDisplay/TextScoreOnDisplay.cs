using UnityEngine;
using UnityEngine.UI;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class TextScoreOnDisplay
    {
        #region Fields

        private Text _text;

        #endregion


        #region ClassLifeCycles

        public TextScoreOnDisplay(GameObject textScoreObject)
        {
            _text = textScoreObject.GetComponentInChildren<Text>();
        }

        #endregion


        #region Methods

        public void Display(int score)
        {
            _text.text = InterpreterNumbersForScoreUI.Format(score);
        }

        #endregion
    }
}
