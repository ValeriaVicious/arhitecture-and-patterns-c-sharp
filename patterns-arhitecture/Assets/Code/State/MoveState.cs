

namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class MoveState : State
    {
        public override void Handle(CharacterMovementState characterMovement)
        {
            characterMovement.State = new FireState();
        }
    }
}
