using UnityEngine;

namespace RollABoll
{
    [CreateAssetMenu(fileName = "PlayerData", menuName = "GameData/Player", order = 1)]
    class PlayerData : ScriptableObject
    {
        public PlayerStruct playerStruct;
        public Vector3 spawnPosition;
        public GameObject Player;
    }
}
