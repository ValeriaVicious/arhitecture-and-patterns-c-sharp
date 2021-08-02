using System.Collections;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class CoroutineController
    {
        #region Fields

        private IEnumerator _taskRoutine;

        #endregion


        #region ClassLifeCycles

        public CoroutineController(IEnumerator task)
        {
            _taskRoutine = task;
        }

        #endregion


        #region Methods

        public IEnumerator Start()
        {
            while (_taskRoutine.MoveNext())
            {
                yield return _taskRoutine.Current;
            }
        }

        #endregion
    }
}
