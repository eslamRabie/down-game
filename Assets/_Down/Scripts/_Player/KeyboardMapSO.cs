using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{
    [CreateAssetMenu]
    internal class KeyboardMapSO : ScriptableObject
    { 
        [SerializeField] internal KeyCode _mLeft;
        [SerializeField] internal KeyCode _mRight;
        [SerializeField] internal KeyCode _dash;
        [SerializeField] internal KeyCode _powerUp;
    }

}