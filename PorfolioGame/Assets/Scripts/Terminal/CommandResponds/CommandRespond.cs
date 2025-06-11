using Data;
using UnityEngine;

namespace Terminal.CommandResponds
{
    public abstract class CommandRespond : MonoBehaviour
    {
        [SerializeField] protected CommandDataSo commandDataSo;
        
        public string CommandName => commandDataSo.commandName;
        public string CommandRespondText => commandDataSo.commandRespondText;

        public abstract void ExecuteCommandEvent();
    }
}