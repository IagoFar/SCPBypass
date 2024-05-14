using Exiled.API.Features;

namespace SCPBypass
{
    public class SCPBypass : Plugin<Config>
    {
        public override string Name => "SCPBypass";
        public override string Author => "X341";
        public override string Prefix => "scpbypass";
        public override Version RequiredExiledVersion => new Version(8,0,0);
        public override Version Version => new Version(1, 0, 0);

        public override void OnEnabled()
        {
            base.OnEnabled();
            Exiled.Events.Handlers.Player.InteractingDoor += Handlers.SCPHandler.OnInteract;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Exiled.Events.Handlers.Player.InteractingDoor -= Handlers.SCPHandler.OnInteract;
        }
    }
}
