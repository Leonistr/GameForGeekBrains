using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RollABoll
{
    class GoodBonusView : MonoBehaviour
    {
        public event Action<PlayerModel> onCollide = delegate { };


        private void OnTriggerEnter(Collider other)
        {
            
        }
    }
}
