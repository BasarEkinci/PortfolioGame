using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "CommandDataSo", menuName = "Scriptable Objects/CommandDataSo")]
    public class CommandDataSo : ScriptableObject
    {
        public string commandName;
        [TextArea(10, 10)]
        public string commandRespondText;
    }
}
