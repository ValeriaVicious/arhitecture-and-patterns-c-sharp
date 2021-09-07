using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Random = UnityEngine.Random;


namespace MonkeyInTheSpace.GeekBrains.Iterator
{
    public sealed class EnemyIterator : IEnemyIterator
    {
        #region Fields

        private List<IEnemyAbility> _enemyAbilities;

        #endregion


        #region ClassLifeCycles

        public EnemyIterator(List<IEnemyAbility> enemyAbilities)
        {
            _enemyAbilities = enemyAbilities;
        }
        #endregion


        #region Properties

        public int MaxDamage => _enemyAbilities.Select(a => a.DamageOfEnemy).Max();

        public string this[Target index]
        {
            get
            {
                var ability = _enemyAbilities.FirstOrDefault(a => a.Target == index);
                return ability == null ? "Not supported" : ability.ToString();
            }
        }

        #region Methods

        public IEnemyAbility this[int index] => _enemyAbilities[index];

        #endregion
        public IEnumerable<IEnemyAbility> GetAbility()
        {
            while (true)
            {
                yield return _enemyAbilities[Random.Range(0, _enemyAbilities.Count)];
            }
        }

        public IEnumerable<IEnemyAbility> GetAbility(DamageType damageType)
        {
            foreach (IEnemyAbility ability in _enemyAbilities)
            {
                if (ability.DamageType == damageType)
                {
                    yield return ability;
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _enemyAbilities.Count; i++)
            {
                yield return _enemyAbilities[i];
            }
        }


        #endregion
    }

}

