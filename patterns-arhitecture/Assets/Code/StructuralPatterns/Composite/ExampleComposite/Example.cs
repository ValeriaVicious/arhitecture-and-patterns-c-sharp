using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Composite
{
    public sealed class Example : MonoBehaviour
    {
        #region UnityMethods

        private void Start()
        {
            var factory = new FactoryOfCompositePattern();
            var enemies = factory.CreateTheEnemies();
        }

        #endregion
    }
}
