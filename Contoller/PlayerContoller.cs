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
        private Rigidbody _rigidbody;


        public PlayerContoller(PlayerModel model, PlayerView view, (IInputProvider horizontal, IInputProvider vertical) input)
        {
            this._model = model;
            this._view = view;
            _horizontalInput = input.horizontal;
            _verticalInput = input.vertical;
            _horizontalInput.onAxisChange += HorizontalOnAxisChange;
            _verticalInput.onAxisChange += VerticalOnAxisChange;
            _rigidbody = view.gameObject.GetComponent<Rigidbody>();
            
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
            _rigidbody.velocity = new Vector3(_horizontal * _model.PlayerStruct.Speed, 
                _rigidbody.velocity.y, _vertical * _model.PlayerStruct.Speed);
        }

        public void Clean()
        {
            _horizontalInput.onAxisChange -= HorizontalOnAxisChange;
            _verticalInput.onAxisChange -= VerticalOnAxisChange;
        }

        
    }
}