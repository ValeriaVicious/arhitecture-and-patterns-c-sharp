

namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Composite
{
    public sealed class Mag : IEnemy
    {
        #region Properties

        public int Health { get; set; }

        #endregion


        #region Methods

        public static Mag CreateEnemy(int health)
        {
            return new Mag() { Health = health };
        }

        #endregion
    }
}
