using UnityEngine;

public class ConveyorSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;
    public Transform spawnPoint;

    void Start()
    {
        SpawnObject();
    }

    public void SpawnObject()
    {
        int index = Random.Range(0, objectsToSpawn.Length);

        Instantiate(objectsToSpawn[index], spawnPoint.position, spawnPoint.rotation);
    }
}