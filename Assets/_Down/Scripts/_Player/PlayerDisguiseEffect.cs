using System.Threading.Tasks;
using UnityEngine;

namespace SoulPlayer
{
    internal class PlayerDisguiseEffect: IPlayerPowerUpEffect
    {
        private bool is_Disguise;
        internal PlayerDisguiseEffect()
        {
            _dashTimeMS = 3000;
            _numberOfPowerUps = 3;
            is_Disguise = false;
        }
        
        internal override async void Effect(MonoBehaviour behaviour)
        {
           // if (!(movement is PlayerMovement _movement)) return;
            if (!is_Disguise && _numberOfPowerUps > 0)
            {
                _numberOfPowerUps--;
                is_Disguise = true;
                //_movement.Dash(-2);
                await Task.Delay(_dashTimeMS);
                //_movement.Dash(2);
                is_Disguise = false;
            }
        }

        internal override int GetNumberOfPowerUps()
        {
            return _numberOfPowerUps;
        }

        internal override void AddPowerUp()
        {
            _numberOfPowerUps++;
        }

        internal override int GetEffectTimeMS()
        {
            return _dashTimeMS;
        }

        internal override void SetEffectTimeMS(int dashTimeMS)
        {
            _dashTimeMS = dashTimeMS;
        }

        internal bool IsDisguise()
        {
            return is_Disguise;
        }
    }
}