using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class CameraOfTheGame : IBorderCamera
    {

        #region Fields

        private static float _border = 0;
        private static Camera _mainCamera;

        #endregion


        #region ClassLifeCycles

        public CameraOfTheGame()
        {
            _mainCamera = Camera.main;
        }

        #endregion


        #region Properties

        public static float Border
        {
            get
            {
                if (_border == 0)
                {
                    _border = _mainCamera.aspect * _mainCamera.orthographicSize;
                }
                return _border;
            }
        }

        #endregion
    }
}
