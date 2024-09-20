using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AimAndShoot : MonoBehaviour
{
    public float power = 2f;
    public Rigidbody2D rb1;
    public Rigidbody2D rb2;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject Player1;
    public GameObject Player2;
    TrajectoryLine tl1;
    TrajectoryLine tl2;
    public Vector2 minPower;
    public Vector2 maxPower;

    public bool player1turn;

    public TMP_Text messageText;
    //Camera cam;
    public Vector2 force;

    //private Rigidbody2D Player1rb;
    //private Rigidbody2D Player2rb;

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
        
        rb1.gravityScale = 0;
        rb2.gravityScale = 0;

        //Player1rb = Player1.GetComponent<Rigidbody2D>();
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
                //Player1rb.isKinematic = false;
                ball2.SetActive(false);
                ball1.SetActive(true);
                ball1.transform.position = Player1.transform.position;
                rb1.gravityScale = 1;
                rb1.AddForce(force * power, ForceMode2D.Impulse);
                player1turn = false;
                messageText.SetText("Player 2's Turn");
                force.x = 0;
                force.y = 0;
                tl1.RenderLine1(force);
            } else {
                ball2.transform.position = Player2.transform.position;
                rb2.gravityScale = 1;
                ball1.SetActive(false);
                ball2.SetActive(true);
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

