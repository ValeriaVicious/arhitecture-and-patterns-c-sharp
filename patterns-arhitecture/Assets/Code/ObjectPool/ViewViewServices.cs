using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ViewViewServices : IViewService
    {
        #region Fields

        private readonly Dictionary<int, ObjectPool> _viewCache =
            new Dictionary<int, ObjectPool>(_capacityOfObjects);
        private static int _capacityOfObjects = 5;

        #endregion


        #region Methods
        public GameObject CreateTheObject(GameObject prefab)
        {
            if (!_viewCache.TryGetValue(prefab.GetInstanceID(),
                out ObjectPool viewPool))
            {
                viewPool = new ObjectPool(prefab);
                _viewCache[prefab.GetInstanceID()] = viewPool;
            }

            return viewPool.Pop();
        }

        public void DestroyTheObject(GameObject gameObject, GameObject prefab)
        {
            _viewCache[prefab.GetInstanceID()].Push(gameObject);
        }

        #endregion

    }
}
