using System.Collections.Generic;
using UnityEngine;

namespace RollABoll
{
    [CreateAssetMenu(fileName = "GameData", menuName = "GameData/Data", order = 0)]
    class Data : ScriptableObject
    {
        public PlayerData playerData;
        public List<GoodBonusData> GoodBonusDatas;
    }
}
