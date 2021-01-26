using System.Threading.Tasks;
using UnityEngine;

namespace SoulPlayer
{
    internal class PlayerDashEffect: IPlayerPowerUpEffect
    {
        private bool _isDashing;
        

        internal PlayerDashEffect()
        {
            _numberOfPowerUps = 3;
            _isDashing = false;
            //_dashTimeMS = 1000;
        }
        
        internal override async void Effect(MonoBehaviour movement)
        {
            if (!(movement is PlayerMovement _movement)) return;
            if (!_isDashing && _numberOfPowerUps > 0)
            {
                _numberOfPowerUps--;
                _isDashing = true;
                _movement.Dash(-2);
                await Task.Delay(_dashTimeMS);
                _movement.Dash(2);
                _isDashing = false;
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
        
    }
}