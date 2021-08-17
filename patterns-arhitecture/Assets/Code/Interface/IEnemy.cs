using System;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IEnemy
    {
        public HealthOfEnemy Health { get; }
        public int Points { get; }
        public event Action<GameObject> OnTriggerEnterChangedEvent;
    }
}
