using UnityEngine;
using System;
using System.IO;
using System.Collections.Generic;


namespace MonkeyInTheSpace.GeekBrains.StructuralPatterns.Composite
{

    public sealed class FactoryOfCompositePattern
    {
        public List<IEnemy> CreateTheEnemies()
        {
            var dataText = File.ReadAllText("Assets/Code/StructuralPatterns/Composite/data.json");
            var enemiesData = JsonUtility.FromJson<EnemiesData>(dataText);

            var enemiesList = new List<IEnemy>();

            foreach (var item in enemiesData.Enemies)
            {
                var unit = item.UnitData;

                switch (unit.TypeOfUnit)
                {
                    case "mag":
                        var mag = Mag.CreateEnemy(unit.HealthOfUnit);
                        enemiesList.Add(mag);
                        break;
                    case "infantry":
                        var infantry = Infantry.CreateEnemy(unit.HealthOfUnit);
                        enemiesList.Add(infantry);
                        break;
                    default:
                        throw new ArgumentException(nameof(unit.TypeOfUnit), unit.TypeOfUnit, null);
                }
            }
            return enemiesList;
        }
    }
}
