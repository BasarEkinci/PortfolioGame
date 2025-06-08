using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Enums;
using Scriptables;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class TerminalManager : MonoBehaviour
{
    [SerializeField] private CommandEvent commandEvent;
    [SerializeField] private TMP_Text terminalText;
    
    private Dictionary<string,PanelType> _panelCommands = new Dictionary<string, PanelType>
    {
        { "help", PanelType.Help },
        { "about", PanelType.AboutMe },
        { "projects", PanelType.Projects },
        { "contact", PanelType.Contact },
        { "clear", PanelType.Base },
    };
    
    private void OnEnable()
    {
        commandEvent.AddListener(OnCommandReceived);
    }

    private async void OnCommandReceived(string arg0)
    {
        OpenPanel(arg0);
        if (terminalText != null)
        {
            for (int i = 0; i < arg0.Length; i++)
            {
                await Task.Delay(TimeSpan.FromSeconds(Random.Range(0.05f, 0.1f)));
                terminalText.text += arg0[i];
            }
        }
    }

    private void OnDisable()
    {
        commandEvent.RemoveListener(OnCommandReceived);
    }

    private void OpenPanel(string command)
    {
        terminalText.text = "";
        if (_panelCommands.TryGetValue(command, out var panelType))
        {
            Debug.Log($"Opening panel: {command}");
        }
        else
        {
            Debug.LogError($"Unknown command: {command}");
            terminalText.text = $"Error: Unknown command '{command}'";
        }
    }
}
