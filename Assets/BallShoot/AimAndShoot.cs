using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AimAndShoot : MonoBehaviour
{
    public float power = 2f;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;

    TrajectoryLine tl1;
    TrajectoryLine tl2;
    public Vector2 minPower;
    public Vector2 maxPower;

    public bool player1turn;

    public TMP_Text messageText;
    //Camera cam;
    public Vector2 force;

    private void Start() 
    {
        minPower.x = -10;
        minPower.y = -10;
        maxPower.x = 10;
        maxPower.y = 10;
        force.x = 0;
        force.y = 0;
        player1turn = true;

        tl1 = GetComponent<TrajectoryLine>();
        tl2 = GetComponent<TrajectoryLine>();
    
    }

    private void Update() 
    {
        if (player1turn) {
            tl1.RenderLine1(force);
        } else {
            tl2.RenderLine2(force);
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            Debug.Log("Space was pressed");
            force.x = Mathf.Clamp(force.x, minPower.x, maxPower.x);
            force.y = Mathf.Clamp(force.y, minPower.y, maxPower.y);
            if (player1turn) {
                rb1.AddForce(force * power, ForceMode2D.Impulse);
                player1turn = false;
                messageText.SetText("Player 2's Turn");
                force.x = 0;
                force.y = 0;
                tl1.RenderLine1(force);
            } else {
                rb2.AddForce(force * power, ForceMode2D.Impulse);
                player1turn = true;
                messageText.SetText("Player 1's Turn");
                force.x = 0;
                force.y = 0;
                tl2.RenderLine2(force);
            }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Debug.Log("up was pressed");
            force.y += 1;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Debug.Log("down was pressed");
            force.y -= 1;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            Debug.Log("left was pressed");
            force.x -= 1;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            Debug.Log("right was pressed");
            force.x += 1;
        }
    }
}

