using UnityEngine;

namespace SoulPlayer
{

    internal class PlayerMovement : MonoBehaviour
    {
        private Rigidbody2D _playerBody;
        private bool _isCollidinWithWall;
        [SerializeField] private string _wallTagName;

        private void Start()
        {
            _playerBody = GetComponent<Rigidbody2D>();
            _isCollidinWithWall = false;
        }

        internal bool MovePlayer(Vector2 velocity)
        {
            if (_isCollidinWithWall) return false;
            _playerBody.velocity = velocity;
            return true;
        }

        internal bool Dash(Vector2 force)
        {
            return false;
        }

        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.tag == _wallTagName) _isCollidinWithWall = true;
        }

        private void OnCollisionExit2D(Collision2D other)
        {
            if (other.gameObject.tag == _wallTagName) _isCollidinWithWall = false;
        }

    }
}
