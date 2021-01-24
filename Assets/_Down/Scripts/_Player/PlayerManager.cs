using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.Serialization;


namespace SoulPlayer
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField]private PlayerStatusSO _thisPlayerStatusSo;
        [SerializeField] private KeyboardMapSO _thisPlayerKeyboardMap;
        private PlayerKeyboardInput _thisPlayerInput;
        private PlayerMovement _thisPlayerMovement;
        private Vector2 _movementVector;
        private Vector2 _dashVector;
        void Start()
        {
            _thisPlayerInput = new PlayerKeyboardInput();
            _thisPlayerInput._keboardMap = _thisPlayerKeyboardMap;
            _thisPlayerMovement = GetComponent<PlayerMovement>();
        }

        // Update is called once per frame
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
            if (_thisPlayerInput.DashUp())
            {
                _dashVector.y += _thisPlayerStatusSo._playerDashSpeed;
            }
            if (_thisPlayerInput.DashDown())
            {
                _dashVector.y -= _thisPlayerStatusSo._playerDashSpeed;
            }
        }

        private void FixedUpdate()
        {
            _thisPlayerMovement.MovePlayer(_movementVector);
            _thisPlayerMovement.Dash(_dashVector);
            _movementVector = Vector2.zero;
            _dashVector = Vector2.zero;
        }

        internal void EnemyCollisionHandler()
        {
            if (_thisPlayerStatusSo._playerStep == 0)
            {
                if (_thisPlayerStatusSo._playerLevel > 0) _thisPlayerStatusSo._playerLevel--;
            }
            else
            {
                _thisPlayerStatusSo._playerStep--;
            }
        }

    }
}