using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class GameController : MonoBehaviour, IDisposable
    {
        #region Fields

        [SerializeField] private GameConfig _gameConfig;
        private ControllersHandler _controllersHandler;
        private GameInitiallization _gameInitiallization;
        private IBorderCamera _borderOfCamera;

        #endregion


        #region UnityMethods

        private void Awake()
        {
            _controllersHandler = new ControllersHandler();
            _gameInitiallization = new GameInitiallization(_controllersHandler, _gameConfig);
            _borderOfCamera = new CameraOfTheGame();
        }

        private void Start()
        {
            _controllersHandler.Initiallization();
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            _controllersHandler.Execute(deltaTime);
        }

        #endregion


        #region Methods

        public void Dispose()
        {
            _controllersHandler.CleanUp();
        }

        #endregion
    }
}
