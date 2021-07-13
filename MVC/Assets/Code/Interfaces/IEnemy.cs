using System;


namespace MVC
{
    public interface IEnemy : IMove
    {
        event Action<int> OnTriggerEnterChange;
    }
}