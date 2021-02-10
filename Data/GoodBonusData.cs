using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RollABoll
{
    [CreateAssetMenu(fileName = "GoodBonusData", menuName = "GameData/GoodBonus", order = 2)]
    class GoodBonusData : ScriptableObject
    {
        public GoodBonusStruct GoodBonus;
        public GameObject GoodBonusObject;
    }
}
