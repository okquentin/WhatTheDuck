using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Player2Hit : MonoBehaviour
{
    private int player2score;
    public TMP_Text messageText;   
    public GameObject Heart1;
    public GameObject Heart2;
    public GameObject Heart3;

    private bool IsColliding; 
    void OnTriggerEnter2D (Collider2D target) {
            Debug.Log("Collision Detected!");
        if( target.gameObject.tag.Equals("Ball2") == true ){
                if (IsColliding) return;
                IsColliding = true;
                if (player2score == 3) {
                    DestroyHeart(Heart3);
                } else if (player2score == 2) {
                    DestroyHeart(Heart2);
                } else if (player2score == 1) {
                    DestroyHeart(Heart1);
                    if (messageText.text.Equals("")){
                    messageText.SetText("Player 2 Wins!");
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                    }
                }
                target.gameObject.SetActive(false);
                player2score--;
                
                Debug.Log("hit! Player2 Health: " + player2score);
        }
    }

    void DestroyHeart (GameObject Heart) {
        Destroy(Heart);
    }
    private void Start()
    {
        player2score = 3;
    }

    private void Update()
    {
        IsColliding = false;
    }
}
