using System;
using Scriptables;
using UnityEngine;

public class CommandSender : MonoBehaviour
{
    [SerializeField] private CommandEvent commandEvent;
    private string _playerInput = "";

    private void Update()
    {
        _playerInput = GetPlayerInput();
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            commandEvent.RaiseEvent(GetPlayerInput());
            ClearPlayerInput();
        }
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
                if (Input.inputString != " " && Input.inputString != "\n" && Input.inputString != "\r")
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
