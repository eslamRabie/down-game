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
        private PlayerCollisionHandler _collisionHandler;

        private PlayerDashEffect _dashEffect;
        private PlayerDisguiseEffect _disguiseEffect;
        
        
        private Vector2 _movementVector;
        private int _score;
        private int _lightYears;
        private int _playerLevel;
        private int _playerStep;
        private int _playerYPosition;
        
        void Start()
        {
            _thisPlayerInput = new PlayerKeyboardInput();
            _thisPlayerInput._keboardMap = _thisPlayerKeyboardMap;
            _thisPlayerMovement = GetComponent<PlayerMovement>();
            _collisionHandler = this.gameObject.AddComponent<PlayerCollisionHandler>();
            _dashEffect = new PlayerDashEffect();
            _disguiseEffect = new PlayerDisguiseEffect();
            
            _score = 0;
            _lightYears = 0;
            _playerLevel = 0;
            _playerStep = 0;
            _playerYPosition = 0;
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
            if (_thisPlayerInput.Dash())
            {
                _dashEffect.Effect(_thisPlayerMovement);
            }
            if (_thisPlayerInput.PowerUp())
            {
                //_disguiseEffect.Effect(this);
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
            return _dashEffect.GetNumberOfPowerUps();
        }
        public int GetDisguise()
        {
            return _disguiseEffect.GetNumberOfPowerUps();
        }
        
        private void FixedUpdate()
        {
            _thisPlayerMovement.MovePlayer(_movementVector);
            _movementVector = Vector2.zero;
        }

        internal void EnemyCollision()
        {
            if(_disguiseEffect.IsDisguise()) return;
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
        internal void CollectDash()
        {
            _dashEffect.AddPowerUp();
        }
        
        internal void CollectDisguise()
        {
            _disguiseEffect.AddPowerUp();
        }
        
        private void UpdatePlayerYPosition(int step)
        {
            switch (step)
            {
                case 1:
                    _playerYPosition = 3;
                    break;
                case 2:
                    _playerYPosition = 0;
                    break;
                case 3:
                    _playerYPosition = -4;
                    break;
                default:
                    break;
            }
            var pos = transform.position;
            transform.position = new Vector3(pos.x, _playerYPosition, pos.z); 
        }
        
       

    }
}