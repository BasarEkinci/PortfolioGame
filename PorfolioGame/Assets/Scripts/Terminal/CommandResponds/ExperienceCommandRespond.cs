using UnityEngine;

namespace Terminal.CommandResponds
{
    public class ExperienceCommandRespond : CommandRespond
    {
        public override void ExecuteCommandEvent()
        {
            Debug.Log("Experience Command Executed");
        }
    }
}