using UnityEngine;


namespace RollABoll
{
    internal class PlayerContoller : IExecutable, ICleanable
    {
        private PlayerModel _model;
        private PlayerView _view;
        private IInputProvider _horizontalInput;
        private IInputProvider _verticalInput;
        private float _vertical;
        private float _horizontal;


        public PlayerContoller(PlayerModel model, PlayerView view, (IInputProvider horizontal, IInputProvider vertical) input)
        {
            this._model = model;
            this._view = view;
            _horizontalInput = input.horizontal;
            _verticalInput = input.vertical;
            _horizontalInput.onAxisChange += HorizontalOnAxisChange;
            _verticalInput.onAxisChange += VerticalOnAxisChange;
            view.onDie += Clean;
        }

        private void HorizontalOnAxisChange(float value)
        {
            _horizontal = value * -1;
        }

        private void VerticalOnAxisChange(float value)
        {
            _vertical = value * -1;
        }

        public void Execute(float deltaTime)
        {
            
            var speed = _model.PlayerStruct.Speed * deltaTime;
            var moveDirection = new Vector3(_horizontal * speed, 0.0f, _vertical * speed);
            _view.transform.Translate(moveDirection);
        }

        public void Clean()
        {
            _horizontalInput.onAxisChange -= HorizontalOnAxisChange;
            _verticalInput.onAxisChange -= VerticalOnAxisChange;
        }
    }
}