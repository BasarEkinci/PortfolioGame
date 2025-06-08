using Enums;
using UnityEngine;

namespace Panels
{
    public abstract class PanelPase : MonoBehaviour
    {
        public PanelType panelType;
        
        public abstract void LoadPanel();
        public abstract void UnloadPanel();
    }
}