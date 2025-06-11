using System.Collections.Generic;
using Terminal.CommandResponds;
using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "CommandDatabase", menuName = "Scriptable Objects/CommandDatabase", order = 0)]
    public class CommandRespondDatabaseSo : ScriptableObject
    {
        [SerializeField] private List<CommandRespond> userCommandResponds;
        [SerializeField] private List<CommandRespond> systemCommandResponds;

        public CommandRespond GetUserCommandRespond(string cmd)
        {
            return userCommandResponds.Find(command => command.CommandName == cmd);
        }

        public CommandRespond GetSystemCommandRespond(string cmd)
        {
            return systemCommandResponds.Find(command => command.CommandName == cmd);
        }
        
        public List<CommandRespond> GetAllUserCommandResponds()
        {
            return userCommandResponds;
        }
        
        public List<CommandRespond> GetAllSystemCommandResponds()
        {
            return systemCommandResponds;
        }
    }
}