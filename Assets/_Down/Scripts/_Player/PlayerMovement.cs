using UnityEngine;

namespace SoulPlayer
{

    internal class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D _playerBody;
        private bool _isLeftWallCollision;
        private bool _isRightWallCollision;
        private PlayerManager _playerManager;

        private string _leftWallTag = "LeftWall";
        private string _rightWallTag = "RightWall";

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

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(_leftWallTag)) _isLeftWallCollision = true;
            if (other.gameObject.CompareTag(_rightWallTag)) _isRightWallCollision = true;
            if(other.gameObject.CompareTag("PowerUp")) _playerManager.PowerUpCollisionHandler();
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.CompareTag(_leftWallTag)) _isLeftWallCollision = false;
            if (other.gameObject.CompareTag(_rightWallTag)) _isRightWallCollision = false;
        }

    }
}
