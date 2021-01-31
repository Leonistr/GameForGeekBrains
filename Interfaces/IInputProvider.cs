using System;

namespace RollABoll
{
    internal interface IInputProvider : IController
    {
        event Action<float> onAxisChange;

        void GetAxis();
    }
}