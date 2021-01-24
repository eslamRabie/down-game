using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    public class KeyboardMapSO : ScriptableObject
    { 
        [SerializeField] public KeyCode _mLeft;
        [SerializeField] public KeyCode _mRight;
        [SerializeField] public KeyCode _dUp;
        [SerializeField] public KeyCode _dDown;
    }

}