using Scriptables;
using UnityEngine;

namespace Terminal.Commands
{
    public abstract class BaseCommandArea : MonoBehaviour
    {
        public CommandData commandData;
        public string CommandName => commandData.commandName;
        public abstract void Execute();
    }
}