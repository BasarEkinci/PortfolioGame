using Inputs;
using Scriptables;
using TMPro;
using UnityEngine;

public class CommandSender : MonoBehaviour
{
    [SerializeField] private TMP_Text currentText;
    [SerializeField] private InputManager inputManager;
    [SerializeField] private CommandEvent commandEvent;
    private string _playerInput = "";

    private void OnEnable()
    {
        inputManager.OnCommandSend += SendPlayerInput;
    }

    private void Update()
    {
        _playerInput = GetPlayerInput();
        currentText.text = "Welcome to BasarOS v1.0\nType 'help' to see available commands\n\n" +
                           $"C:\\user\\basar> {_playerInput}";
    }
    
    private void OnDisable()
    {
        inputManager.OnCommandSend -= SendPlayerInput;
    }

    private void SendPlayerInput()
    {
        commandEvent.RaiseEvent(_playerInput);
        ClearPlayerInput();
    }
    
    private string GetPlayerInput()
    {
        foreach (char c in Input.inputString) 
        { 
            if (c == '\b') 
            { 
                if (_playerInput.Length != 0) 
                { 
                    _playerInput = _playerInput.Substring(0, _playerInput.Length - 1);
                }
            }
            else 
            { 
                if (Input.inputString != "\n" && Input.inputString != "\r")
                {
                    _playerInput += c;
                } 
            }
        }
        return _playerInput;
    }
        
    private void ClearPlayerInput()
    {
        _playerInput = "";
    }
}
