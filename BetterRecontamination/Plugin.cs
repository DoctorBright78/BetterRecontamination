using System;
using Exiled.API.Features;

namespace BetterRecontamination
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Doc";
        public override string Name { get; } = "BetterRecontamination";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        public static Plugin Instance;
        
        public override void OnEnabled()
        {
            Instance = this;
            RegisterEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnregisterEvents();
            base.OnDisabled();
        }

        public void RegisterEvents()
        {
            Exiled.Events.Handlers.Player.EnteringFemurBreaker += EventHandlers.OnEnterFemurBreaker;
            Exiled.Events.Handlers.Server.RoundStarted += EventHandlers.OnRoundStart;
        }

        public void UnregisterEvents()
        {
            Exiled.Events.Handlers.Player.EnteringFemurBreaker -= EventHandlers.OnEnterFemurBreaker;
            Exiled.Events.Handlers.Server.RoundStarted -= EventHandlers.OnRoundStart;
        }
    }
}
