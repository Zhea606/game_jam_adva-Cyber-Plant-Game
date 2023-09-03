using System.Collections.Generic;
using UnityEngine;

public class RespawnManager : MonoBehaviour
{
    public GameObject[] objectsToRespawn;
    public Transform[] spawnPositions;
    private List<Transform> usedSpawnPoints = new List<Transform>();
    void Start()
    {
        RespawnObjects();
    }

    void RespawnObjects()
    {
        foreach (GameObject obj in objectsToRespawn)
        {
            Transform spawnPoint = GetUnusedSpawnPoint();

            if (spawnPoint != null)
            {
                obj.transform.position = spawnPoint.position;
                usedSpawnPoints.Add(spawnPoint);
            }
        }
    }

    Transform GetUnusedSpawnPoint()
    {
        List<Transform> availableSpawnPoints = new List<Transform>();
        foreach (Transform spawnPoint in spawnPositions)
        {
            if (!usedSpawnPoints.Contains(spawnPoint))
            {
                availableSpawnPoints.Add(spawnPoint);
            }
        }

        if (availableSpawnPoints.Count > 0)
        {
            int randomIndex = Random.Range(0, availableSpawnPoints.Count);
            return availableSpawnPoints[randomIndex];
        }
        else
        {
            return null; // No available spawn points
        }
    }
}