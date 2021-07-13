using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "GameConfig", menuName = "Configs/GameConfig", order = 0)]
    public sealed class GameConfig : ScriptableObject
    {
        public PlayerConfig PlayerConfig;
    }
}
