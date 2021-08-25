using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains
{
    [CreateAssetMenu(fileName = "ScoreUIConfig", menuName = "Configs/ScoreUIConfig", order = 0)]
    public sealed class UIScoreConfig : ScriptableObject
    {
        public GameObject Score;
        public GameObject DestroyedEnemies;
    }
}
