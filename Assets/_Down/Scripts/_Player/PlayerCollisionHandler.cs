using System;
using UnityEngine;

namespace SoulPlayer
{
    internal class PlayerCollisionHandler: MonoBehaviour
    {
        private PlayerManager _playerManager;
        private PlayerMovement _playerMovement; 
        
        private string _leftWallTag = "LeftConfiner";
        private string _rightWallTag = "RightConfiner";
        
        
        private void Start()
        {
            _playerManager = GetComponent<PlayerManager>();
            _playerMovement = GetComponent<PlayerMovement>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("Collided");
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