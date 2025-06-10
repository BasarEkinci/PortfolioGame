using UnityEngine;

namespace Terminal.Commands
{
    public class ContactCommandArea : BaseCommandArea
    {
        public override void Execute()
        {
            Debug.Log(commandData.responseText);            
        }
    }
}