using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    [CreateAssetMenu]
    public class PlayerStatusSO : ScriptableObject
    {
        [SerializeField] public string _playerName;
        [SerializeField] public int _playerLevel;
        [SerializeField] public int _playerStep;
        [SerializeField] public int _playerMoveSpeed;
        [SerializeField] public int _playerDashSpeed;
    }
}
