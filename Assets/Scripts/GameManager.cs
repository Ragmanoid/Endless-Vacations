using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshPro MainLabel;
    public DialogueManager Dm;

    private void Start()
    {
        Dm = FindObjectOfType<DialogueManager>();
    }

    public void SetLabel(string text)
    {
        MainLabel.SetText(text);
    }
}