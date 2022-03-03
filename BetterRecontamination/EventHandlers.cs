using Exiled.API.Enums;
using Exiled.Events.EventArgs;

namespace BetterRecontamination
{
    public static class EventHandlers
    {
        private static int _numSacrifices = 0;

        public static void OnRoundStart() => _numSacrifices = 0;
        
        public static void OnEnterFemurBreaker(EnteringFemurBreakerEventArgs ev)
        {
            if (_numSacrifices < Plugin.Instance.Config.NumSacrifices - 1)
            {
                ev.IsAllowed = false;
                ev.Player.Kill(DamageType.FemurBreaker);
                _numSacrifices++;
            }
        }
    }
}