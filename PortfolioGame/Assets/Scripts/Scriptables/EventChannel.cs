using UnityEngine;
using UnityEngine.Events;

namespace Scriptables
{
    [CreateAssetMenu(fileName = "EventChannel", menuName = "ScriptableObjects/Events", order = 0)]
    public class EventChannel<T> : ScriptableObject
    {
        private UnityAction<T> _onEventReceived;
    
        public void RaiseEvent(T value)
        {
            if (_onEventReceived != null)
            {
                _onEventReceived.Invoke(value);
            }
        }
    
        public void AddListener(UnityAction<T> listener)
        {
            _onEventReceived += listener;
        }
    
        public void RemoveListener(UnityAction<T> listener)
        {
            _onEventReceived -= listener;
        }
    }
}