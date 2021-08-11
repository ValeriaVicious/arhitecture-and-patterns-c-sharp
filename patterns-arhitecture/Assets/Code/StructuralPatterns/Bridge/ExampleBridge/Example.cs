using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new Enemy(new MagicalAttack(), new Infantry());
        }
    }
}
