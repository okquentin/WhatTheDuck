using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public CanvasGroup OptionPanel;
    public CanvasGroup ControlsPanel;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Option()
    {
        OptionPanel.alpha = 1;
        //ControlPanel.alpha = 0;
        OptionPanel.blocksRaycasts = true;
    }

    public void Back()
    {
        OptionPanel.alpha = 0;
        ControlsPanel.alpha = 0;
        OptionPanel.blocksRaycasts = false;
        ControlsPanel.blocksRaycasts = false;
    }

    public void Controls()
    {
        //OptionPanel.alpha = 1;
        //OptionPanel.blocksRaycasts = true;
        ControlsPanel.alpha = 1;
        ControlsPanel.blocksRaycasts = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
