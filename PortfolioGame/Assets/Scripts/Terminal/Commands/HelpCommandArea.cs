using UnityEngine;

namespace Terminal.Commands
{
    public class HelpCommandArea : BaseCommandArea
    {
        public override void Execute()
        {
            Debug.Log(commandData.responseText);
        }
    }
}