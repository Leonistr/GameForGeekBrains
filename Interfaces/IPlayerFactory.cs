using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    interface IPlayerFactory : IController
    {
        IController Create((IInputProvider horizontal, IInputProvider vertical) input);
    }
}
