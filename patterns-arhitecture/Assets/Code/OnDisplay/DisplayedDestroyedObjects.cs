using UnityEngine;
using UnityEngine.UI;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class DisplayedDestroyedObjects
    {
        #region Fields

        private Text _text;

        #endregion


        #region ClassLifeCycles

        public DisplayedDestroyedObjects(GameObject textScoreUI)
        {
            _text = textScoreUI.GetComponentInChildren<Text>();
        }

        #endregion


        #region Methods

        public void AddObject(Enemy enemy)
        {
            enemy.OnDestroy += OnDestroyEnemy;
        }

        public void RemoveObject(Enemy enemy)
        {
            enemy.OnDestroy -= OnDestroyEnemy;
        }

        public void OnDestroyEnemy(string objectName)
        {
            _text.text = $"Вы уничтожили: {objectName}";
        }

        #endregion
    }
}
