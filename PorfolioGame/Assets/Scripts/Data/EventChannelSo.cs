using UnityEngine;
using UnityEngine.Events;

namespace Data
{
    [CreateAssetMenu(fileName = "EventChannel", menuName = "Scriptable Objects/EventChannel", order = 0)]
    public class EventChannelSo<T> : ScriptableObject
    {
        private UnityAction<T> _onEventReceived;
        
        public void RaiseEvent(T eventData)
        {
            _onEventReceived?.Invoke(eventData);
        }
        
        public void RegisterListener(UnityAction<T> listener)
        {
            _onEventReceived += listener;
        }
        
        public void UnregisterListener(UnityAction<T> listener)
        {
            _onEventReceived -= listener;
        }
    }
}