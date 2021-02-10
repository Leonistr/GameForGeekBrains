using UnityEngine;

namespace RollABoll
{
    internal class GoodBonusController : IExecutable
    {
        private GoodBonusModel _goodBonusModel;
        private GoodBonusView _goodBonusView;
        private GoodBonusType _bonusType;
        private Color _color;

        public GoodBonusController(GoodBonusModel goodBonusModel, GoodBonusView goodBonusView)
        {
            this._goodBonusModel = goodBonusModel;
            this._goodBonusView = goodBonusView;
            this._bonusType = _goodBonusModel.GoodBonusStruct.BonusType;
            _goodBonusView.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            
        }

        public void Execute(float deltaTime)
        {
            if (_bonusType == GoodBonusType.Healer)
            {
                _goodBonusView.transform.localPosition = new Vector3(_goodBonusView.transform.localPosition.x,
                 Mathf.PingPong(Time.time, _goodBonusModel.GoodBonusStruct.FlyLength),
                 _goodBonusView.transform.localPosition.z);
            }
            else if(_bonusType == GoodBonusType.Speeder)
            {
                _goodBonusView.gameObject.GetComponent<Renderer>().material.color = new Color(_color.r, _color.g, _color.b, Mathf.PingPong(Time.time, 1f));
                           
            }
        }

        public void Interact()
        {

        }
    }
}