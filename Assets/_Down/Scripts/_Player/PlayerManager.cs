using System.Threading.Tasks;
using UnityEngine;


namespace SoulPlayer
{
    public class PlayerManager : MonoBehaviour
    {
        //score // power ups // 
        [SerializeField] private PlayerStatusSO _thisPlayerStatusSo;
        [SerializeField] private KeyboardMapSO _thisPlayerKeyboardMap;
        private Animator _playerAnimator;
        
        private PlayerKeyboardInput _thisPlayerInput;
        private PlayerMovement _thisPlayerMovement;
        
        private Vector2 _movementVector;

        private bool _isDashing;
        [SerializeField][Range(100, 5000)]private int _dashTimeMS = 1000;
        
        
        private int _score;
        private int _lightYears;
        [SerializeField][Range(0, 10)]private int _dashes;
        private int _powerUp;
        private int _playerLevel;
        private int _playerStep;
        private int _playerYPosition;
        
        void Start()
        {
            _thisPlayerInput = new PlayerKeyboardInput();
            _thisPlayerInput._keboardMap = _thisPlayerKeyboardMap;
            _thisPlayerMovement = GetComponent<PlayerMovement>();
            
            
            _score = 0;
            _lightYears = 0;
            _dashes = 3;
            _powerUp = 0;
            _playerLevel = 0;
            _playerStep = 0;
            _playerYPosition = 0;
            _isDashing = false;
        }

        void Update()
        {
            if (_thisPlayerInput.MoveRight())
            {
                _movementVector.x += _thisPlayerStatusSo._playerMoveSpeed;
            }
            if (_thisPlayerInput.MoveLeft())
            {
                _movementVector.x -= _thisPlayerStatusSo._playerMoveSpeed;
            }
            if (_thisPlayerInput.Dash() && !_isDashing)
            {
                Dash();
            }
            if (_thisPlayerInput.PowerUp())
            {
                PowerUp();
            }
        }
        
        public int GetLightYears()
        {
            return _lightYears;
        }

        public int GetScore()
        {
            return _score;
        }

        public void SetScore(int score)
        {
            _score = score;
            if (_score % 10 == 0)
            {
                _dashes++;
            }

            if (_score % 50 == 0)
            {
                _playerStep++;
                if (_playerStep > 3)
                {
                    _playerStep = 0;
                    _playerLevel++;
                }
                _lightYears++;
                UpdatePlayerYPosition(_playerStep);
            }
        }

        public int GetDashes()
        {
            return _dashes;
        }
        public int GetPowerUps()
        {
            return _powerUp;
        }
        
        private void FixedUpdate()
        {
            _thisPlayerMovement.MovePlayer(_movementVector);
            _movementVector = Vector2.zero;
        }


        async void Dash()
        {
            if (_dashes > 0)
            {
                _dashes--;
                _isDashing = true;
                _thisPlayerMovement.Dash(-2);
                await  Task.Delay(_dashTimeMS);
                _thisPlayerMovement.Dash(2);
                _isDashing = false;
            }
        }
        
        private void PowerUp()
        {
            if (_powerUp > 0)
            {
                _powerUp--;
                //write functionality
            }
        }

        internal void EnemyCollisionHandler()
        {
            if (_playerStep == 0)
            {
                if (_playerLevel > 0)
                {
                    _playerLevel--;
                }
            }
            else
            {
                _playerStep--;
            }
        }

        private void UpdatePlayerYPosition(int step)
        {
            switch (step)
            {
                case 1:
                    _playerYPosition = 100;
                    break;
                case 2:
                    _playerYPosition = 700;
                    break;
                case 3:
                    _playerYPosition = 1300;
                    break;
                default:
                    break;
            }
            var pos = transform.position;
            transform.position = new Vector3(pos.x, _playerYPosition, pos.z); 
        }
        
        internal void PowerUpCollisionHandler()
        {
            _powerUp++;
        }

    }
}