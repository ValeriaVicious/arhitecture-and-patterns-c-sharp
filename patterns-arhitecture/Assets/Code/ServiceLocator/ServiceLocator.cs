using System;
using System.Collections.Generic;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class ServiceLocator
    {
        #region Fields

        private static readonly Dictionary<Type, object> _serviceLocatorContainer =
            new Dictionary<Type, object>();

        #endregion


        #region Methods

        public static void SetService<T>(T value) where T : class
        {
            var typeValue = typeof(T);

            if (!_serviceLocatorContainer.ContainsKey(typeValue))
            {
                _serviceLocatorContainer[typeValue] = value;
            }
        }

        public static T Resolve<T>()
        {
            var type = typeof(T);

            if (_serviceLocatorContainer.ContainsKey(type))
            {
                return (T)_serviceLocatorContainer[type];
            }
            return default;
        }

        #endregion
    }
}
