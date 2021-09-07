

namespace MonkeyInTheSpace.GeekBrains
{
    public abstract class State
    {
        public abstract void Handle(CharacterMovementState characterMovementType);
    }
}
