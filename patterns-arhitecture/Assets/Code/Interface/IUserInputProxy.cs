using System;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IUserInputProxy
    {
        public event Action<float> AxisOnChange;
        public void GetAxis();
    }
}
