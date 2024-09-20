using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class Hit : MonoBehaviour
{
    public TMP_Text message1Text;
    private int player1score;
    public CircleCollider2D triggerBox;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered: " + other.name);

        if (other.CompareTag("Ball") && triggerBox != null)
        {
            Debug.Log("Ball detected!");
            player1score++;
            message1Text.SetText("Player1: " + player1score);
            Debug.Log("hit! Player1 score: " + player1score);
        }
    }

    private void Start()
    {
        player1score = 0;
    }

    private void Update()
    {
        // This line is unnecessary as OnTriggerEnter will be called automatically
        // OnTriggerEnter(triggerBox);
    }
}
