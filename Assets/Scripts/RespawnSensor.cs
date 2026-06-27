using UnityEngine;

public class RespawnSensor : MonoBehaviour
{
    public ConveyorSpawner spawner;   // drag your spawner here

    // prevent multiple spawns while an object is inside the trigger
    private bool busy = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item") && !busy && spawner.gameObject.activeInHierarchy)
        {
            busy = true;

            // spawn a new object
            spawner.SpawnObject();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Item"))
        {
            busy = false;  // ready for next object
        }
    }
}