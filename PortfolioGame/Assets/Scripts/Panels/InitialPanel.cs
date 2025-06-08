using TMPro;
using UnityEngine;

namespace Panels
{
    public class InitialPanel : PanelPase
    {
        [SerializeField] private TMP_Text initialText;

        private void Start()
        {
            UnloadPanel();
        }

        public override void LoadPanel()
        {
            gameObject.SetActive(true);
        }

        public override void UnloadPanel()
        {
            gameObject.SetActive(false);
        }
    }
}