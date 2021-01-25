using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    [CreateAssetMenu]
    internal class PlayerStatusSO : ScriptableObject
    {
        [SerializeField][Range(0, 10)] internal int _playerMoveSpeed;
        [SerializeField][Range(0, 3)] internal int _playerDashSpeed;
    }
}
