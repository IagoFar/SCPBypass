using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System.Numerics;

namespace SCPBypass.Handlers
{
    internal static class SCPHandler
    {
        public static void OnInteract(InteractingDoorEventArgs ev)
        {
            Log.Debug("Opening door" + ev.Door);
            if (ev.Door.IsKeycardDoor)
            {
                ev.IsAllowed = true;
            }
        }
    }
}
