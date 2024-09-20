using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DinoManager : MonoBehaviour
{
    public GameObject[] dinoPrefabs;
    public Transform spawnPoint;
    
    private GameObject currentDino;

    void Start()
    {
        // Initialize the current dino to null
        currentDino = null;
        dinoPrefabs = new GameObject[3];
        dinoPrefabs[0] = Resources.Load<GameObject>("basicDino");
        dinoPrefabs[1] = Resources.Load<GameObject>("cowboyDino");
        dinoPrefabs[2] = Resources.Load<GameObject>("wizardDino");
    }

    public void SpawnDino(int dinoType)
    {
        // Check if we already have a dino
        if (currentDino != null)
        {
            Destroy(currentDino);
        }

        // Spawn the new dino
        currentDino = Instantiate(dinoPrefabs[dinoType], spawnPoint.position, spawnPoint.rotation);
        Debug.Log("dino spawned");
    }
}
