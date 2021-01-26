using UnityEngine;

namespace SoulPlayer
{

    internal class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D _playerBody;
        private bool _isLeftWallCollision;
        private bool _isRightWallCollision;
        private PlayerManager _playerManager;

        private void Start()
        {
            _playerBody = GetComponent<Rigidbody2D>();
            _isLeftWallCollision = false;
            _isRightWallCollision = false;
        }

        internal bool MovePlayer(Vector2 velocity)
        {
            if (Mathf.RoundToInt(velocity.x) == 1 && _isRightWallCollision) return false;
            if (Mathf.RoundToInt(velocity.x) == -1 && _isLeftWallCollision) return false;
            _playerBody.velocity = velocity;
            return true;
        }

        internal void Dash(int posInc)
        {
            transform.position += Vector3.up * posInc;
        }

        internal void LeftWallCollision(bool state)
        {
            _isLeftWallCollision = state;
        }
        
        internal void RightWallCollision(bool state)
        {
            _isRightWallCollision = state;
        }
        

    }
}
