using System.Collections;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour
{
    public GameObject bubblePrefab;
    public Transform spawnPoint;

    void Start()
    {
        StartCoroutine(SpawnBubbles());
    }

    IEnumerator SpawnBubbles()
    {
        while (true)
        {
            Instantiate(bubblePrefab, spawnPoint.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}

