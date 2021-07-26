using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class CameraOfTheGame : IBorderCamera
    {

        #region Fields

        private static float _border = 0;

        #endregion


        #region Properties

        public static float Border
        {
            get
            {
                if (_border == 0)
                {
                    var getCamera = Camera.main;
                    _border = getCamera.aspect * getCamera.orthographicSize;
                }
                return _border;
            }
        }

        #endregion
    }
}
