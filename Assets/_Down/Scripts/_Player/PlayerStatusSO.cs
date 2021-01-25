using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    [CreateAssetMenu]
    internal class PlayerStatusSO : ScriptableObject
    {
        [SerializeField] internal int _playerMoveSpeed;
        [SerializeField] internal int _playerDashSpeed;
    }
}
