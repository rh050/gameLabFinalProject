using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersTFindMovement : MonoBehaviour
{
    public float speed = 3f;
    private static float randonNumber;
    public static bool isCaught = false;

    

    void Start()
    {
        randonNumber = Random.Range(0f, 0.5f);
        Vector2 PlayerPosition = new Vector2(Player.movement.x+randonNumber, Player.movement.y+randonNumber); 
        transform.position = PlayerPosition;
        InvokeRepeating("SetRandomPosition", 0f, 1f);
    }

    void SetRandomPosition()
    {
        Vector2 targetPosition = new Vector2(Random.Range(-10f, 10f), Random.Range(-10f, 10f));
        StartCoroutine(MoveToPosition(targetPosition)); 
    }

    IEnumerator MoveToPosition(Vector2 targetPosition)
    {
        while ((Vector2)transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            yield return null; 
        }
    }
}