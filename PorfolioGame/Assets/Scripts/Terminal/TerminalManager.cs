using System;
using System.Threading.Tasks;
using Data;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Terminal
{
    public class TerminalManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text loadingText;
        [SerializeField] private Transform terminalContentArea;
        [SerializeField] private CommandRespondDatabaseSo commandResponds;
        [SerializeField] private CommandSentEvent commandSentEvent;

        private void OnEnable()
        {
            commandSentEvent.RegisterListener(OnCommandSent);
            ShowLoadingAnimation();
            //show the load animation and instantiate the base command
        }
        
        private void OnDisable()
        {
            commandSentEvent.UnregisterListener(OnCommandSent);
        }

        private void OnCommandSent(string cmd)
        {
            //instantiate the command response based on the command sent if the command matches any existing commands
        }
        
        private async void ShowLoadingAnimation()
        {
            await Task.Delay(500);
            TMP_Text text = Instantiate(loadingText, terminalContentArea);
            int loadingCount = Random.Range(6, 10);
            for (int i = 0; i < loadingCount; i++)
            {
                text.text = "\\";
                await Task.Delay(TimeSpan.FromSeconds(0.15f));
                text.text = "|";
                await Task.Delay(TimeSpan.FromSeconds(0.15f));
                text.text = "/";
                await Task.Delay(TimeSpan.FromSeconds(0.15f));
            }
            Destroy(text.gameObject);
        }
    }
}