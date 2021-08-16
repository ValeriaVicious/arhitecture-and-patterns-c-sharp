using System.Collections.Generic;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class ControllersHandler : IInitialization, IExecute, ILateExecute, ICleanup, IFixedExecute
    {
        #region Fields

        private readonly List<IInitialization> _initializationControllers;
        private readonly List<IExecute> _executeControllers;
        private readonly List<ILateExecute> _lateExecuteControllers;
        private readonly List<ICleanup> _cleanUpControllers;
        private readonly List<IFixedExecute> _fixedExecuteControllers;

        #endregion


        #region ClassLifeCycles

        public ControllersHandler()
        {
            _initializationControllers = new List<IInitialization>();
            _executeControllers = new List<IExecute>();
            _lateExecuteControllers = new List<ILateExecute>();
            _cleanUpControllers = new List<ICleanup>();
            _fixedExecuteControllers = new List<IFixedExecute>();
        }

        #endregion


        #region Methods

        public void CleanUp()
        {
            for (int i = 0; i < _cleanUpControllers.Count; ++i)
            {
                _cleanUpControllers[i].CleanUp();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _executeControllers.Count; ++i)
            {
                _executeControllers[i].Execute(deltaTime);
            }
        }

        public void Initiallization()
        {
            for (int i = 0; i < _initializationControllers.Count; ++i)
            {
                _initializationControllers[i].Initiallization();
            }
        }

        public void LateExecute(float deltaTime)
        {
            for (int i = 0; i < _lateExecuteControllers.Count; ++i)
            {
                _lateExecuteControllers[i].LateExecute(deltaTime);
            }
        }

        public void Add(IController controller)
        {
            if (controller is IInitialization initialization)
            {
                _initializationControllers.Add(initialization);
            }

            if (controller is IExecute execute)
            {
                _executeControllers.Add(execute);
            }

            if (controller is ILateExecute lateExecute)
            {
                _lateExecuteControllers.Add(lateExecute);
            }

            if (controller is ICleanup cleanUp)
            {
                _cleanUpControllers.Add(cleanUp);
            }

            if (controller is IFixedExecute fixedExecute)
            {
                _fixedExecuteControllers.Add(fixedExecute);
            }
        }

        public void FixedExecute(float deltaTime)
        {
            for (int i = 0; i < _fixedExecuteControllers.Count; ++i)
            {
                _fixedExecuteControllers[i].FixedExecute(deltaTime);
            }
        }

        #endregion
    }
}