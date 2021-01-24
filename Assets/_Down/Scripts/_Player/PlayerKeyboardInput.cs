using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{

    internal class PlayerKeyboardInput : IPlayerInput
    {
        [SerializeField] private KeyboardMapSO _keboardMap;
        internal override bool MoveRight()
        {
            return Input.GetKeyDown(_keboardMap._mRight);
        }

        internal override bool MoveLeft()
        {
            return Input.GetKeyDown(_keboardMap._mLeft);
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
