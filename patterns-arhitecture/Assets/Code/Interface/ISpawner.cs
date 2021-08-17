using System;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface ISpawner
    {
        public event Action<IEnemy> OnSpawnEnemy;
    }
}
