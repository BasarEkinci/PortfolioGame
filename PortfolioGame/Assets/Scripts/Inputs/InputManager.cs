using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class InputManager : MonoBehaviour
    {
        public event Action OnCommandSend;
        private InputActions _inputActions;
        private void OnEnable()
        {
            if (_inputActions == null)
            {
                _inputActions = new InputActions();
                _inputActions.User.Enable();
                _inputActions.User.SendCommand.performed += OnSendCommand;
            } 
        }
        
        private void OnDisable()
        {
            if (_inputActions != null)
            {
                _inputActions.User.SendCommand.performed -= OnSendCommand;
                _inputActions.User.Disable();
            }
        }
        public void OnSendCommand(InputAction.CallbackContext context)
        {
            if (context.performed)
            {
                Debug.Log("Command received");
                OnCommandSend?.Invoke();
            }
        }
    }
}
