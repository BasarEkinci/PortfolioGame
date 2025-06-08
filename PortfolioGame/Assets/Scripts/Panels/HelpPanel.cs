using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Panels
{
    public class HelpPanel : PanelPase
    {
        [SerializeField] private List<GameObject> items;
        
        public override async void LoadPanel()
        {
            foreach (var item in items)
            {
                await Task.Delay(TimeSpan.FromSeconds(Random.Range(0, 0.1f)));
                item.SetActive(true);
            }
        }

        public override void UnloadPanel()
        {
            foreach (var item in items)
            {
                item.SetActive(false);
            }
            gameObject.SetActive(false);
        }
    }
}