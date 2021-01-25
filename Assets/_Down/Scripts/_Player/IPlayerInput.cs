using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{
    internal abstract class IPlayerInput
    {
        internal abstract bool MoveRight();
        internal abstract bool MoveLeft();
        internal abstract bool Dash();
        internal abstract bool PowerUp();
    }
}
