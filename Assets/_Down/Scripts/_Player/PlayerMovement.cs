using System;
using System.Collections;
using System.Collections.Generic;
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

        internal bool MovePlayer(Vector2 force)
        {
            if (_isCollidinWithWall) return false;
            _playerBody.AddForce(force);
            return true;
            
        }

        internal bool Dash(Vector2 force)
        {
            return false;
        }

        private void OnCollisionEnter(Collision other)
        {
            if(other.gameObject.tag == _wallTagName) _isCollidinWithWall = true;
        }

        private void OnCollisionExit(Collision other)
        {
            if (other.gameObject.tag == _wallTagName) _isCollidinWithWall = false;
        }
        
    }
}
