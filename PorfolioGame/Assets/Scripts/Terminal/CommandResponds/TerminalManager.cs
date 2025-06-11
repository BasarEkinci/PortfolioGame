using System.Collections.Generic;
using Data;
using UnityEngine;

namespace Terminal.CommandResponds
{
    public class TerminalManager : MonoBehaviour
    {
        [SerializeField] private Transform terminalContentArea;
        [SerializeField] private List<CommandRespond> commandResponds;
        [SerializeField] private CommandSentEvent commandSentEvent;

        private void OnEnable()
        {
            commandSentEvent.RegisterListener(OnCommandSent);
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