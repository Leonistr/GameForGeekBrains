using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    public class GoodBonusInitializer : IInitializable
    {
        private IBonusFactory _goodBonusFactory;
        private List<IController> _controller = new List<IController>();

        public GoodBonusInitializer(IBonusFactory bonusFactories)
        {
            _goodBonusFactory = bonusFactories;
            _controller = _goodBonusFactory.Create();
            
        }
        public void Initialize()
        {
            
        }

        public List<IController> GetControllers()
        {
            return _controller;
        }
    }
}
