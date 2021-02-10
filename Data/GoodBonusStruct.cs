using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEditor;

namespace RollABoll
{
    [Serializable]
    public struct GoodBonusStruct
    {
        public BonusStruct BonusStruct;
        public GoodBonusType BonusType;
        [Range(1, 10)] public float HPToGive;
        [Range(1, 10)] public float SpeedToGive;
        public float FlyLength;
    }
}
