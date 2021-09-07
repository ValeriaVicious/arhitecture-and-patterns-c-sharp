using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Bridge
{
    internal sealed class Example : MonoBehaviour
    {
        private void Start()
        {
            var magicalEnemy = new Enemy(new MagicalAttack(), new Infantry());
            var meleeEnemy = new Enemy(new MeleeAttack(), new Infantry());
            var rangedEnemy = new Enemy(new RangedAttack(), new Infantry());
            var hitmanEnemy = new Enemy(new IronSightShoot(), new Infantry());
        }
    }
}
