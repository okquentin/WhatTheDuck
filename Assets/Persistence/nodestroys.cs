using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nodestroys : MonoBehaviour
{

    public GameObject ball1;
    public GameObject ball2;
    public GameObject Player1;
    public GameObject Player2;
    public Camera main_camera;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(ball1);
        DontDestroyOnLoad(ball2);
        DontDestroyOnLoad(Player1);
        DontDestroyOnLoad(Player2);
        DontDestroyOnLoad(main_camera);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (SceneManager.GetActiveScene().buildIndex == 1) {    //should be true when the dinoboat scene loads
            
        }
        if (SceneManager.GetActiveScene().buildIndex == 2) {    //should be true when the lighthouse scene loads

        }
        if (SceneManager.GetActiveScene().buildIndex == 3) {    //should be true when the dinoboat scene loads

        }
    }
}
