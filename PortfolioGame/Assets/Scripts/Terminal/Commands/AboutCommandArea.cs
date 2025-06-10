using UnityEngine;

namespace Terminal.Commands
{
    public class AboutCommandArea : BaseCommandArea
    {
        public override void Execute()
        {
            Debug.Log(commandData.responseText);
        }
    }
}