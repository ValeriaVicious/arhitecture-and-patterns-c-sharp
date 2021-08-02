using System.Collections;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public static class CoroutineExtensions
    {
        #region Fields

        private static AsyncOperationBehaviour _asyncOperationBehaviour = null;

        #endregion


        #region Methods

        public static Coroutine StartCoroutine(this IEnumerator task,
            out CoroutineController coroutineController)
        {
            Initialize();
            if (task == null)
            {
                throw new System.ArgumentNullException(nameof(task));
            }

            coroutineController = new CoroutineController(task);
            return _asyncOperationBehaviour.StartCoroutine(coroutineController.Start());
        }

        private static void Initialize()
        {
            if (_asyncOperationBehaviour != null)
            {
                return;
            }

            GameObject gameObject = new GameObject();
            Object.DontDestroyOnLoad(gameObject);
            gameObject.name = "AsyncOperationExtensionCoroutine";
            gameObject.hideFlags = HideFlags.HideAndDontSave;

            _asyncOperationBehaviour = gameObject.AddComponent<AsyncOperationBehaviour>();
        }

        #endregion
    }
}
