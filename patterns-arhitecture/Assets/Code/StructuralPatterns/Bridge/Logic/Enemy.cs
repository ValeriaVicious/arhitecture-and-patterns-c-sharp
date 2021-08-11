

namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Bridge
{
    internal sealed class Enemy
    {
        #region Fields

        private readonly IAttack _attack;
        private readonly IMove _move;

        #endregion


        #region ClassLifeCycles

        public Enemy(IAttack attack, IMove move)
        {
            _attack = attack;
            _move = move;
        }

        #endregion


        #region Methods

        public void Attack()
        {
            _attack.Attack();
        }

        public void Move()
        {
            _move.Move();
        }

        #endregion
    }
}
