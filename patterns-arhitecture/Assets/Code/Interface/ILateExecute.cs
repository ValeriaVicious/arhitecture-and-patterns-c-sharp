

namespace MonkeyInTheSpace.GeekBrains
{
    public interface ILateExecute : IController
    {
        public void LateExecute(float deltaTime);
    }
}
