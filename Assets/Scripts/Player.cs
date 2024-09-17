using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    public static Vector2 movement;
    public static int gameScore = 0;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Hider")&& PlayersTFindMovement.isCaught == false)
        {
            GameEvents.HiderFound(); //call the event
            gameScore++;
            Debug.Log("Hider has been found! Player find " + Player.gameScore+" hiders");
            PlayersTFindMovement.isCaught = true;
            //change color
            other.GetComponent<SpriteRenderer>().color = Color.black;
        }
    }
}
