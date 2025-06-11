using UnityEngine;

namespace Data
{
    [CreateAssetMenu(fileName = "CommandSentEvent", menuName = "Scriptable Objects/Events/CommandSentEvent", order = 0)]
    public class CommandSentEvent : EventChannelSo<string>
    {
        
    }
}