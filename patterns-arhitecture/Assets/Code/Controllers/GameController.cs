using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GameController : MonoBehaviour
    {
        #region Fields

        private List<IExecute> _executeObjects;
        private References _references;
        private Player _player;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _executeObjects = new List<IExecute>();
            _references = new References();
            _player = null;

            if (_player == null)
            {
                _player = _references.PlayerMonkey;
            }

            _executeObjects.Add(_player);
        }

        private void Update()
        {
            UpdateExecuteObjects();
        }

        #endregion


        #region Methods

        private void UpdateExecuteObjects()
        {
            for (int i = 0; i < _executeObjects.Count; i++)
            {
                var executeObject = _executeObjects[i];

                if (executeObject == null)
                {
                    continue;
                }
                else
                {
                    executeObject.Execute();
                }
            }
        }

        #endregion
    }
}
