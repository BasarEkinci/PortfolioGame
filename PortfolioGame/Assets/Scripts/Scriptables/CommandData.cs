using UnityEngine;

namespace Scriptables
{
    [CreateAssetMenu(fileName = "CommandData", menuName = "Scriptable Objects/CommandData")]
    public class CommandData : ScriptableObject
    {
        public string commandName;
        [TextArea(10,10)] public string responseText;
    }
}
