using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Decorator
{
    internal sealed class Sight : ISight
    {
        #region Properties

        public GameObject SightInstance { get; }

        public Transform SightPosition;

        public float ForceOfSight { get; }

        #endregion


        #region ClassLifeCycles

        public Sight(GameObject sightInstance, Transform position, float forceOfSight)
        {
            SightInstance = sightInstance;
            ForceOfSight = forceOfSight;
            SightPosition = position;
        }

        #endregion

    }
}
