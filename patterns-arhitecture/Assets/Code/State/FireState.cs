

namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class FireState : State
    {
        public override void Handle(CharacterMovementState characterMovement)
        {
            characterMovement.State = new DeadState();
        }
    }
}
