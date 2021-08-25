using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class StateExample : MonoBehaviour
    {
        private void Start()
        {
            CharacterMovementState characterMovementState = new CharacterMovementState(new MoveState());
            characterMovementState.Request();
            characterMovementState.Request();
            characterMovementState.Request();
            characterMovementState.Request();
        }
    }
}
