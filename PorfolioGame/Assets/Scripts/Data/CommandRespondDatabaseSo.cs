using System.Collections.Generic;
using Terminal.CommandResponds;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "CommandDatabase", menuName = "Scriptable Objects/CommandDatabase", order = 0)]
    public class CommandRespondDatabaseSo : ScriptableObject
    {
        [SerializeField] private List<string> availableUserCommands;
        [SerializeField] private List<CommandRespond> userCommandResponds;
        [SerializeField] private List<CommandRespond> systemCommandResponds;

        public CommandRespond GetUserCommandRespond(string cmd)
        {
            if (IsCommandAvailable(cmd))
                return GetSystemCommandRespond("error");
        
            var commandRespond = userCommandResponds.Find(command => command.CommandName == cmd);
            return commandRespond != null ? commandRespond : GetSystemCommandRespond("error");
        }

        public CommandRespond GetSystemCommandRespond(string cmd)
        {
            if (IsCommandAvailable(cmd))
                return null;
        
            return systemCommandResponds.Find(command => command.CommandName == cmd);
        }

        private bool IsCommandAvailable(string cmd)
        {
            return !string.IsNullOrEmpty(cmd) && availableUserCommands.Contains(cmd);
        }

        public List<string> GetAllAvailableUserCommands()
        {
            return new List<string>(availableUserCommands);
        }

        public List<CommandRespond> GetAllUserCommandResponds()
        {
            return new List<CommandRespond>(userCommandResponds);
        }

        public List<CommandRespond> GetAllSystemCommandResponds()
        {
            return new List<CommandRespond>(systemCommandResponds);
        }
    }
}