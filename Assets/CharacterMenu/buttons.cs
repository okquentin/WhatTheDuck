using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Buttons : MonoBehaviour
{   
    public void firstBackPressed(){
        SceneManager.LoadScene("MainMenu");
    }
    public void BackPressed(){
        SceneManager.LoadScene("CharacterMenu");
    }

    public void DinoPressed(){
        SceneManager.LoadScene("DinoSelection");
    }

    public void DuckPressed(){
        SceneManager.LoadScene("DuckSelection");
    }
}