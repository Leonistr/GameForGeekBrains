using UnityEngine;

namespace RollABoll
{
    class GameController : MonoBehaviour
    {
        [SerializeField] private Data _data;
        
        private Controllers controllers;
        private void Start()
        {
            controllers = new Controllers();
            new GameInitializer(_data, controllers);
        }

        private void Update()
        {
            var deltaTime = Time.deltaTime;
            controllers.Execute(deltaTime);
        }

        private void OnDestroy()
        {
            controllers.Clean();
        }
    }
}
