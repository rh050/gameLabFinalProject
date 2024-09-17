using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject hiderPrefab;
    public int hiderCount = 1;
    public float spawnRangeX = 10f;
    public float spawnRangeY = 5f;

    void Start()
    {
        for (int i = 0; i < hiderCount; i++)
        {
            Vector2 randomPosition = new Vector2(Random.Range(-spawnRangeX, spawnRangeX), Random.Range(-spawnRangeY, spawnRangeY));
            Instantiate(hiderPrefab, randomPosition, Quaternion.identity);
        }
    }
}
