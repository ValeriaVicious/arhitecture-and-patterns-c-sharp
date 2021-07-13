using System.Collections.Generic;
using UnityEngine;


namespace MVC
{
    public sealed class CompositeMove : IMove
    {
        #region Fields

        private List<IMove> _moves = new List<IMove>();

        #endregion


        #region Methods

        public void AddUnit(IMove unit)
        {
            _moves.Add(unit);
        }

        public void RemoveUnit(IMove unit)
        {
            _moves.Remove(unit);
        }

        public void Move(Vector3 point)
        {
            for (int i = 0; i < _moves.Count; i++)
            {
                _moves[i].Move(point);
            }
        }

        #endregion
    }
}