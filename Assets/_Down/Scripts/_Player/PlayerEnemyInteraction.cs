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
        
      
    }
}