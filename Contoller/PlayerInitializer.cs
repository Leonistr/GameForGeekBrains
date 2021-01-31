using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    class PlayerInitializer : IInitializable
    {
        private IPlayerFactory _playerFactory;
        private IController _playerController;

        public PlayerInitializer(IPlayerFactory playerFactory, (IInputProvider horizontal, IInputProvider vertical) input)
        {
            _playerFactory = playerFactory;
            _playerController = playerFactory.Create(input);
        }

        public void Initialize()
        {
            
        }

        public IController GetController()
        {
            return _playerController;
        }
    }
}
