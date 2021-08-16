using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ObjectPool
    {
        #region Fields

        private readonly Stack<GameObject> _stackObjects =
            new Stack<GameObject>();
        private readonly GameObject _prefab;

        #endregion


        #region ClassLifeCycles

        public ObjectPool(GameObject prefab)
        {
            _prefab = prefab;
        }

        #endregion


        #region Methods

        public void Push(GameObject gameObject)
        {
            _stackObjects.Push(gameObject);
            gameObject.SetActive(false);
        }

        public GameObject Pop()
        {
            GameObject gameObject;
            if (_stackObjects.Count == 0)
            {
                gameObject = Object.Instantiate(_prefab);
            }
            else
            {
                gameObject = _stackObjects.Pop();
            }
            gameObject.SetActive(true);
            return gameObject;
        }

        #endregion
    }
}
