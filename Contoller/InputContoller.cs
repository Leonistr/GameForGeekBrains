using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    class InputContoller : IExecutable
    {
        private readonly IInputProvider _horizontalProvider;
        private readonly IInputProvider _verticalProvider;

        public InputContoller((IInputProvider horizontal, IInputProvider vertical) input)
        {
            _horizontalProvider = input.horizontal;
            _verticalProvider = input.vertical;
        }
        public void Execute(float deltaTime)
        {
            _horizontalProvider.GetAxis();
            _verticalProvider.GetAxis();
        }
    }
}
