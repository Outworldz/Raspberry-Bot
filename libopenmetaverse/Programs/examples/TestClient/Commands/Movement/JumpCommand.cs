using System;
using OpenMetaverse;

namespace OpenMetaverse.TestClient
{
    public class JumpCommand: Command
    {
        public JumpCommand(TestClient testClient)
		{
			Name = "jump";
			Description = "Jumps or flies up";
            Category = CommandCategory.Movement;
		}

        public override string Execute(string[] args, UUID fromAgentID)
        {
            bool start = true;

            if (args.Length == 1 && args[0].ToLower() == "stop")
                start = false;

            if (start)
            {
                Client.Self.Jump(true);
                return "Started Jumping";
            }
            else
            {
                Client.Self.Jump(false);
                return "Stopped Jumping";
            }
        }
    }
}
