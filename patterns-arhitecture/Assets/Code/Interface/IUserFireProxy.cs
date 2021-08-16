using System;


namespace MonkeyInTheSpace.GeekBrains
{
    public interface IUserFireProxy
    {
        public event Action<bool> FireInputGetDown;
        public void GetFireDown();
    }
}
