using UnityEngine;

namespace SoulPlayer
{
    public class PlayerEnemyInteraction : MonoBehaviour
    {
        private PlayerManager thisdPlayerManager;

        private void Start()
        {
            thisdPlayerManager = GetComponent<PlayerManager>();
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            Debug.Log("collided");
            if (other.gameObject.CompareTag("Enemy"))
            {
                thisdPlayerManager.EnemyCollisionHandler();
            }
        }
    }
}