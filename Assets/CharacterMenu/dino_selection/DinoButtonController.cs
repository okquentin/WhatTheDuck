using UnityEngine;
using UnityEngine.UI;

public class DinoButtonController : MonoBehaviour
{
    public DinoManager dinoManager;
    public Button[] dinoButtons;

    void Start()
    {
        // Hook up button events
        for (int i = 0; i < dinoButtons.Length; i++)
        {
            int buttonIndex = i;
            dinoButtons[i].onClick.AddListener(() => SpawnDino(buttonIndex));
        }
    }

    void SpawnDino(int dinoType)
    {
        dinoManager.SpawnDino(dinoType);
    }
}