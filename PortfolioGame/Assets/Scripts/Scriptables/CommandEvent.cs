using UnityEngine;

namespace Scriptables
{
    [CreateAssetMenu(fileName = "CommandEvent", menuName = "ScriptableObjects/Events", order = 0)]
    public class CommandEvent : EventChannel<string>
    {
        
    }
}