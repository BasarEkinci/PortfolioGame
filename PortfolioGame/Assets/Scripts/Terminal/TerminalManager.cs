using System.Collections.Generic;
using Terminal.Commands;
using TMPro;
using UnityEngine;

namespace Terminal
{
    public class TerminalManager : MonoBehaviour
    {
        [SerializeField] private List<BaseCommandArea> commandList;
        [SerializeField] private TMP_Text initialText;
        [SerializeField] private TMP_InputField inputField;

        private readonly Dictionary<string, BaseCommandArea> _commands = new();

        private void Awake()
        {
            foreach (var commandArea in commandList)
            {
                RegisterCommand(commandArea);
            }            
        }

        private void RegisterCommand(BaseCommandArea commandArea)
        {
            if (_commands.ContainsKey(commandArea.CommandName))
            {
                Debug.LogWarning($"Command '{commandArea.CommandName}' is already registered.");
                return;
            }
            _commands[commandArea.CommandName.ToLower()] = commandArea;
        }
    }
}