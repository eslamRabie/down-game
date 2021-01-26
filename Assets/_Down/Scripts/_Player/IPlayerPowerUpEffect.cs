using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{
    internal abstract class IPlayerPowerUpEffect
    {
        protected int _numberOfPowerUps;
        internal abstract void Effect(MonoBehaviour behaviour);
        internal abstract int GetNumberOfPowerUps();
        internal abstract void AddPowerUp();
    }
}