using System;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IUserAccelerationProxy
    {
        public event Action<bool> IsAccelerationOnChange;
        public void GetAcceleration();
    }
}
