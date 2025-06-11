using UnityEngine;

namespace Terminal.CommandResponds
{
    public class LinksCommandRespond : CommandRespond
    {
        public override void ExecuteCommandEvent()
        {
            Debug.Log("links command executed");
        }
    }
}