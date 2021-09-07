

namespace MonkeyInTheSpace.GeekBrains
{
    public sealed class EnemyAbility : IEnemyAbility
    {
        #region Properties

        public string NameOfEnemy { get; }

        public int DamageOfEnemy { get; }

        public Target Target { get; }

        public DamageType DamageType { get; }

        #endregion


        #region ClassLifeCycles

        public EnemyAbility(string name, int damage, Target target, DamageType damageType)
        {
            NameOfEnemy = name;
            DamageOfEnemy = damage;
            Target = target;
            DamageType = damageType;
        }

        #endregion


        #region Methods

        public override string ToString()
        {
            return NameOfEnemy;
        }

        #endregion
    }
}
