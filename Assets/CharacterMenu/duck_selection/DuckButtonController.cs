using UnityEngine;
using UnityEngine.UI;

public class DuckButtonController : MonoBehaviour
{
    public DuckManager duckManager;
    public Button[] duckButtons;

    void Start()
    {
        // Hook up button events
        for (int i = 0; i < duckButtons.Length; i++)
        {
            int buttonIndex = i;
            duckButtons[i].onClick.AddListener(() => SpawnDuck(buttonIndex));
        }
    }

    void SpawnDuck(int duckType)
    {
        duckManager.SpawnDuck(duckType);
    }
}