using Data;
using UnityEngine;

namespace Terminal
{
    public class TerminalManager : MonoBehaviour
    {
        [SerializeField] private Transform terminalContentArea;
        [SerializeField] private CommandRespondDatabaseSo commandResponds;
        [SerializeField] private CommandSentEvent commandSentEvent;

        private void OnEnable()
        {
            commandSentEvent.RegisterListener(OnCommandSent);
            //show the load animation and instantiate the base command
        }
        
        private void OnDisable()
        {
            commandSentEvent.UnregisterListener(OnCommandSent);
        }

        private void OnCommandSent(string cmd)
        {
            //instantiate the command response based on the command sent if the command matches any existing commands
        }
    }
}