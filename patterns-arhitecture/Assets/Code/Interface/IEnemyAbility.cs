

namespace MonkeyInTheSpace.GeekBrains
{
    public interface IEnemyAbility
    {
        public string NameOfEnemy { get; }
        public int DamageOfEnemy { get; }
        public Target Target { get; }
        public DamageType DamageType { get; }

    }
}
