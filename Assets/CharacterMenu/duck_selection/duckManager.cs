using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DuckManager : MonoBehaviour
{
    public GameObject[] duckPrefabs;
    public Transform spawnPoint;
    
    private GameObject currentDuck;

    void Start()
    {
        // Initialize the current duck to null
        currentDuck = null;
        duckPrefabs = new GameObject[3];
        duckPrefabs[0] = Resources.Load<GameObject>("basicDuck");
        duckPrefabs[1] = Resources.Load<GameObject>("goofyDuck");
        duckPrefabs[2] = Resources.Load<GameObject>("pirateDuck");
    }

    public void SpawnDuck(int duckType)
    {
        // Check if we already have a duck
        if (currentDuck != null)
        {
            Destroy(currentDuck);
        }

        // Spawn the new duck
        currentDuck = Instantiate(duckPrefabs[duckType], spawnPoint.position, spawnPoint.rotation);
        Debug.Log("duck spawned");

        
    }
}
