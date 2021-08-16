using System.Collections.Generic;


namespace MonkeyInTheSpace.GeekBrains
{
    internal sealed class CompositeMoveTheEnemy : IMoveEnemy
    {
        #region Fields

        private List<IMoveEnemy> _moveEnemies = new List<IMoveEnemy>();

        #endregion


        #region Methods

        public void AddUnit(IMoveEnemy moveEnemy)
        {
            _moveEnemies.Add(moveEnemy);
        }

        public void RemoveUnit(IMoveEnemy moveEnemy)
        {
            _moveEnemies.Remove(moveEnemy);
        }

        public void TheEnemyMove(float horizontal, float vertical, float deltaTime)
        {
            for (int i = 0; i < _moveEnemies.Count; i++)
            {
                _moveEnemies[i].TheEnemyMove(horizontal, vertical, deltaTime);
            }
        }

        #endregion
    }
}
