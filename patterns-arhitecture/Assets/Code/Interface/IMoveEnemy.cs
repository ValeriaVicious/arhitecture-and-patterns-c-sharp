

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IMoveEnemy : IController
    {
        public void TheEnemyMove(float horizontal, float vertical, float deltaTime);
    }
}