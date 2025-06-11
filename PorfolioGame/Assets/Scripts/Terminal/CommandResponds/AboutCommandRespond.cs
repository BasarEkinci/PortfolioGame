using UnityEngine;

namespace Terminal.CommandResponds
{
    public class AboutCommandRespond : CommandRespond
    {
        public override void ExecuteCommandEvent()
        {
            Debug.Log("About Command Executed");
        }
    }
}