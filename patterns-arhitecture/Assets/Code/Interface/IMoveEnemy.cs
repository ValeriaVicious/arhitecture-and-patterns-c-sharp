

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IMoveEnemy : IController
    {
        public void Move(float horizontal, float vertical, float deltaTime);
    }
}