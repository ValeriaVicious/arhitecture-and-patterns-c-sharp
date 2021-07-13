using UnityEngine;


namespace MVC
{
    public sealed class MoveController : IExecute, ICleanUp
    {
        #region Fields

        private readonly Transform _unit;
        private readonly IUnit _unitData;
        private float _horizontal;
        private float _vertical;
        private Vector3 _move;
        private IUserInput _horizontalInputProxy;
        private IUserInput _verticalInputProxy;
        private (IUserInput inputHorizontal, IUserInput inputVertical) p;

        #endregion


        #region ClassLifeCycles

        public MoveController((IUserInput inputHorizontal, IUserInput inputVertical)input,
            Transform unit,IUnit unitData)
        {
            _unit = unit;
            _unitData = unitData;
            _horizontalInputProxy = input.inputHorizontal;
            _verticalInputProxy = input.inputVertical;
            _horizontalInputProxy.AxisChange += HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisChange += VerticalAxisChange;
        }

        #endregion


        #region Methods

        private void VerticalAxisChange(float value)
        {
            _vertical = value;
        }

        private void HorizontalOnAxisOnChange(float value)
        {
            _horizontal = value;
        }

        public void Cleanup()
        {
            _horizontalInputProxy.AxisChange -= HorizontalOnAxisOnChange;
            _verticalInputProxy.AxisChange -= VerticalAxisChange;
        }

        public void Execute(float deltaTime)
        {
            var speed = deltaTime * _unitData.Speed;
            _move.Set(_horizontal * speed, _vertical * speed, 0.0f);
            _unit.localPosition += _move;
        }

        #endregion
    }
}
