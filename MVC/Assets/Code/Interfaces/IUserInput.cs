using System;


namespace MVC
{
    public interface IUserInput : IController
    {
        event Action<float> AxisChange;
        void GetAxis();
    }
}
