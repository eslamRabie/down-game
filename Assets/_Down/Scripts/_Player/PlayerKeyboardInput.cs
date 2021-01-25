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
            return Input.GetKey(_keboardMap._mRight);;
        }

        internal override bool MoveLeft()
        {
            return Input.GetKey(_keboardMap._mLeft);
        }

        internal override bool Dash()
        {
            return Input.GetKeyDown(_keboardMap._dash);
        }

        internal override bool PowerUp()
        {
            return Input.GetKeyDown(_keboardMap._powerUp);
        }
    }
}
