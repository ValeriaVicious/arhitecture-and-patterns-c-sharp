using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IViewService
    {
        public void CreateTheObject(GameObject prefab);
        public void DestroyTheObject(GameObject gameObject);
    }
}
