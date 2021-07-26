

namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class Asteroid : Enemy
    {
        #region Fields

        private float _timeForDestroy = 5.0f;

        #endregion


        #region UnityMethods

        private void Start()
        {
            Destroy(gameObject, _timeForDestroy);
        }

        #endregion


        #region Methods

        public override void MoveTheEnemy()
        {
            transform.position = new UnityEngine.Vector3(transform.position.x, 5.0f, 0.0f);
        }

        #endregion
    }
}
