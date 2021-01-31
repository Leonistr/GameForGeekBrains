using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RollABoll
{
    interface IExecutable : IController
    {
        void Execute(float deltaTime);
    }
}
