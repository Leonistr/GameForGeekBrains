using UnityEngine;

namespace RollABoll
{
    class PlayerFactory : IPlayerFactory
    {
        private PlayerData _playerData;
        private Camera camera;
        private Vector3 offset;

        public PlayerFactory(PlayerData playerData)
        {
            _playerData = playerData;
            camera = Camera.main;
            offset = new Vector3(0f, 2f, 1f);
        }

        public IController Create((IInputProvider horizontal, IInputProvider vertical) input)
        {
            var model = new PlayerModel(_playerData.playerStruct);
            var view = Object.Instantiate(_playerData.Player, _playerData.spawnPosition, Quaternion.identity).AddComponent<PlayerView>();
            var controller = new PlayerContoller(model, view, input);
            camera.transform.parent = view.transform;
            camera.transform.position += offset;
            camera.transform.LookAt(view.transform);
            return controller;
        }
    }
}
