

namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class DeadState : State
    {
        public override void Handle(CharacterMovementState characterMovementType)
        {
            characterMovementType.State = new MoveState();
        }
    }
}
