using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace MonkeyInTheSpace.GeekBrains.Iterator
{
    public interface IEnemyIterator
    {
        public IEnemyAbility this[int index] { get; }
        public string this[Target index] { get; }
        public int MaxDamage { get; }
        public IEnumerable<IEnemyAbility> GetAbility();
        public IEnumerable<IEnemyAbility> GetAbility(DamageType damageType);
        public IEnumerator GetEnumerator();
    }
}
