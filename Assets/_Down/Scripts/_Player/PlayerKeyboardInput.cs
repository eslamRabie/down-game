using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    internal class PlayerKeyboardInput : IPlayerInput
    {
        internal KeyboardMapSO _keboardMap;
        
        internal override bool MoveRight()
        {
            var x= Input.GetKey(_keboardMap._mRight);
            Debug.Log(x);
            return x;
        }

        internal override bool MoveLeft()
        {
            return Input.GetKey(_keboardMap._mLeft);
        }

        internal override bool DashUp()
        {
            return Input.GetKeyDown(_keboardMap._dUp);
        }

        internal override bool DashDown()
        {
            return Input.GetKeyDown(_keboardMap._dDown);
        }
    }
}
