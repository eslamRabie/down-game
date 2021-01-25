using UnityEngine;

namespace SoulPlayer
{
    internal class PlayerEnemyInteraction : MonoBehaviour
    {
        private PlayerManager _playerManager;

        private void Start()
        {
            _playerManager = GetComponent<PlayerManager>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                _playerManager.EnemyCollisionHandler();
            }
        }
    }
}