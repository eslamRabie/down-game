using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SoulPlayer
{
    internal abstract class IPlayerPowerUpEffect
    {
        protected int _numberOfPowerUps;
        [SerializeField][Range(100, 5000)]protected int _dashTimeMS = 1000;
        internal abstract void Effect(MonoBehaviour behaviour);
        internal abstract int GetNumberOfPowerUps();
        internal abstract void AddPowerUp();
        internal abstract int GetEffectTimeMS();
        internal abstract void SetEffectTimeMS(int dashTimeMS);

    }
}