using UnityEngine;

namespace Terminal.CommandResponds
{
    public class HelpCommandRespond : CommandRespond
    {
        public override void ExecuteCommandEvent()
        {
            Debug.Log("Help Command Executed");
        }
    }
}