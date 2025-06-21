using Monocle;
using MonoMod.ModInterop;
using System;

namespace Celeste.Mod.VortexHelper.Misc;

internal static class CommunalHelperInterop
{
    [ModImportName("CommunalHelper.DashStates")]
    internal static class DashStatesImports
    {
        public static Func<Action<Player>, Action<Player>, Component> DreamTunnelInteraction;
    }

    public static bool TryCreateDreamTunnelInteraction(Action<Player> onPlayerEnter, Action<Player> onPlayerExit, out Component interaction)
    {
        interaction = DashStatesImports.DreamTunnelInteraction?.Invoke(onPlayerEnter, onPlayerExit);
        return interaction is not null;
    }
}