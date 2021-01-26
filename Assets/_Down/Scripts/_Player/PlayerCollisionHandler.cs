using UnityEngine;

namespace SoulPlayer
{
    internal class PlayerCollisionHandler: MonoBehaviour
    {
        private Rigidbody2D _playerBody2D;
        private Collider2D _playerCollider2D;
        private PlayerManager _playerManager;
        private PlayerMovement _playerMovement; 
        
        private string _leftWallTag = "LeftConfiner";
        private string _rightWallTag = "RightConfiner";
        
        internal void AddBody2D(Rigidbody2D playerBody)
        {
            _playerBody2D = playerBody;
        }

        internal void AddCollider(Collider2D playerCollider)
        {
            _playerCollider2D = playerCollider;
        }

        void AddPlayer(Transform player)
        {
            _playerManager = player.GetComponent<PlayerManager>();
            _playerBody2D = player.GetComponent<Rigidbody2D>();
            _playerCollider2D = player.GetComponent<Collider2D>();
            _playerMovement = player.GetComponent<PlayerMovement>();
        }
        
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(_leftWallTag)) _playerMovement.LeftWallCollision(true);
            if (other.gameObject.CompareTag(_rightWallTag)) _playerMovement.RightWallCollision(true);
            if (other.gameObject.CompareTag("Disguise"))
            {
                Destroy(other.gameObject);
                _playerManager.CollectDisguise();
            }
            if (other.gameObject.CompareTag("Dash"))
            {
                Destroy(other.gameObject);
                _playerManager.CollectDash();
            }
            if (other.gameObject.CompareTag("Enemy"))
            {
                _playerManager.EnemyCollision();
            }
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(_leftWallTag)) _playerMovement.LeftWallCollision(false);
            if (other.gameObject.CompareTag(_rightWallTag)) _playerMovement.LeftWallCollision(false);
        }
        
        
    }
}