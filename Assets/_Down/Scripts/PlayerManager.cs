using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SoulPlayer
{
    public class PlayerManager : MonoBehaviour
    {
        [SerializeField]private PlayerStatusSO thisPlayerStatusSo;
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        internal void EnemyCollisionHandler()
        {
            if (thisPlayerStatusSo._playerStep == 0)
            {
                if (thisPlayerStatusSo._playerLevel > 0) thisPlayerStatusSo._playerLevel--;
            }
            else
            {
                thisPlayerStatusSo._playerStep--;
            }
        }

    }
}