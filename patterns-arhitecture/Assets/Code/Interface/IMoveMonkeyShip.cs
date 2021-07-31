

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IMoveMonkeyShip
    {
        float Speed { get; }
        void Move(float horizontal, float vertical, float deltaTime);
    }
}
