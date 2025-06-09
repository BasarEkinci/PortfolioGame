using TMPro;
using UnityEngine;

public class TerminalOutput : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI outputText;

    public void Print(string text)
    {
        outputText.text += "\n" + text;
        transform.Rotate(0, 180, 0);
    }

    public void Clear()
    {
        outputText.text = "";
    }
}
