namespace WinterIsComing.Models
{
    using WinterIsComing.Core;
    using WinterIsComing.Core.Commands;

    public class ExtendedCommandDispatcher : CommandDispatcher
    {
        public override void SeedCommands()
        {
            this.commandsByName["toggle-effector"] = new ToggleEffectorCommand(this.Engine);
            base.SeedCommands();
        }
    }
}
