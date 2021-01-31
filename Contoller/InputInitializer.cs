using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    class InputInitializer : IInitializable
    {
        private IInputProvider _PCInputHorizontal;
        private IInputProvider _PCInputVertical;

        public InputInitializer()
        {
            _PCInputHorizontal = new PlayerHorizontalInputter();
            _PCInputVertical = new PlayerVerticalInputter();
        }
        public void Initialize()
        {
            
        }

        public (IInputProvider horizontal, IInputProvider vertical) GetInput()
        {
            (IInputProvider horizontal, IInputProvider vertical) result = (_PCInputHorizontal, _PCInputVertical);

            return result;
        }
    }
}
