using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IViewService
    {
        public GameObject CreateTheObject(GameObject prefab);
        public void DestroyTheObject(GameObject gameObject);
    }
}
