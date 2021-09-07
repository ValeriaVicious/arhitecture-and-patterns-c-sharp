using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class CharacterMovementState
    {
        #region Fields

        private State _state;

        #endregion


        #region Properties

        public State State
        {
            set
            {
                _state = value;
                Debug.Log("State: " + _state.GetType().Name);
            }
        }

        #endregion


        #region ClassLifeCycles

        public CharacterMovementState(State state)
        {
            State = state;
        }

        #endregion


        #region Methods

        public void Request()
        {
            _state.Handle(this);
        }

        #endregion
    }
}
