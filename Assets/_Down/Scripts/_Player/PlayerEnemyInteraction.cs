using System;
using System.Collections;
using System.Collections.Generic;
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

        private void OnCollisionEnter(Collision other)
        {
            if (other.gameObject.tag == "Enemy")
            {
                thisdPlayerManager.EnemyCollisionHandler();
            }
        }
    }
}