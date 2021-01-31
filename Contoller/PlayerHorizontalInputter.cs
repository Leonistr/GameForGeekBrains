using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RollABoll
{
    class PlayerHorizontalInputter : IInputProvider
    {
        public event Action<float> onAxisChange = f => { };

        public void GetAxis()
        {
            onAxisChange.Invoke(Input.GetAxis(AxisManager.HORIZONTAL));
        }
    }
}
