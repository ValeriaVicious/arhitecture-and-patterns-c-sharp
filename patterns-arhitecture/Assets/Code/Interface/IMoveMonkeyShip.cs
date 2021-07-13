

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IMoveMonkeyShip : IController
    {
        float Speed { get; }
        void Move(float horizontal, float vertical, float deltaTime);
    }
}
