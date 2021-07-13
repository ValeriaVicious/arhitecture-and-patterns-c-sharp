using UnityEngine;


namespace MVC
{
    public sealed class PlayerData : ScriptableObject, IUnit
    {
        #region Fields

        [SerializeField, Range(0, 100)] private float _speed;
        [SerializeField] private Vector2Int _position;

        public Sprite Sprite;

        #endregion


        #region Properties

        public float Speed => _speed;
        public Vector2 Position => _position;

        #endregion
    }
}