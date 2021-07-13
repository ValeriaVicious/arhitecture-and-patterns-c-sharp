using System.Collections.Generic;


namespace MVC
{
    internal sealed class Controllers : IInitialization, IExecute, ILateExecute, ICleanUp
    {
        #region Fields

        private List<IExecute> _executeControllers;
        private List<IInitialization> _initializationControllers;
        private List<ILateExecute> _lateControllers;
        private List<ICleanUp> _cleanUpControllers;

        #endregion


        #region ClassLifeCycles

        public Controllers()
        {
            _initializationControllers = new List<IInitialization>();
            _executeControllers = new List<IExecute>();
            _lateControllers = new List<ILateExecute>();
            _cleanUpControllers = new List<ICleanUp>();
        }

        #endregion


        #region Methods

        public void Cleanup()
        {
            for (int i = 0; i < _cleanUpControllers.Count; ++i)
            {
                _cleanUpControllers[i].Cleanup();
            }
        }

        public void Execute(float deltaTime)
        {
            for (int i = 0; i < _executeControllers.Count; ++i)
            {
                _executeControllers[i].Execute(deltaTime);
            }
        }

        public void Initialization()
        {
            for (int i = 0; i < _initializationControllers.Count; ++i)
            {
                _initializationControllers[i].Initialization();
            }
        }

        public void LateExecute(float deltaTime)
        {
            for (int i = 0; i < _lateControllers.Count; ++i)
            {
                _lateControllers[i].LateExecute(deltaTime);
            }
        }

        internal Controllers Add(IController controller)
        {
            if (controller is IInitialization initialization)
            {
                _initializationControllers.Add(initialization);
            }
            if (controller is IExecute executeController)
            {
                _executeControllers.Add(executeController);
            }
            if (controller is ILateExecute lateExecute)
            {
                _lateControllers.Add(lateExecute);
            }
            if (controller is ICleanUp cleanUpcontroller)
            {
                _cleanUpControllers.Add(cleanUpcontroller);
            }

            return this;
        }

        #endregion
    }
}