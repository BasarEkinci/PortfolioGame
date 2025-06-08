using Scriptables;
using TMPro;
using UnityEngine;

public class TerminalManager : MonoBehaviour
{
    [SerializeField] private CommandEvent commandEvent;
    [SerializeField] private TMP_Text terminalText;
    
    private void OnEnable()
    {
        commandEvent.AddListener(OnCommandReceived);
    }

    private void OnCommandReceived(string arg0)
    {
        if (terminalText != null)
        {
            terminalText.text = $"Sent: {arg0}";
        }
    }

    private void OnDisable()
    {
        commandEvent.RemoveListener(OnCommandReceived);
    }
}
