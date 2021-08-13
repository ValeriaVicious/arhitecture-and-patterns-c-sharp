

namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Composite
{
    public class Infantry : IEnemy
    {
        #region Properties

        public int Health { get; set; }

        #endregion


        #region Methods

        public static Infantry CreateEnemy(int health)
        {
            return new Infantry() { Health = health };
        }

        #endregion
    }
}
