
using System.Collections.Generic;
using UnityEngine;


namespace RollABoll
{
    class GoodBonusFactory : IBonusFactory
    {
        public List<GoodBonusData> _goodBonusData;
        private List<IController> controller = new List<IController>();

        public GoodBonusFactory(List<GoodBonusData> goodBonusData)
        {
            _goodBonusData = goodBonusData;
        }
        public List<IController> Create()
        {

            for (int i = 0; i < _goodBonusData.Count; i++)
            {
                var GoodBonusModel = new GoodBonusModel(_goodBonusData[i].GoodBonus);
                var BonusView = Object.Instantiate(_goodBonusData[i].GoodBonusObject, _goodBonusData[i].GoodBonus.BonusStruct.SpawnPosition,
                    Quaternion.identity).AddComponent<GoodBonusView>();
                var BonusController = new GoodBonusController(GoodBonusModel, BonusView);
                controller.Add(BonusController);
            }
            return controller;
            
        }
    }
}
