using UnityEngine;

public class SystemController : MonoBehaviour
{
    [Header("Simulation Components")]
    public GameObject spawner;          
    public SimpleConveyor conveyor;     

    public void StartSystem()
    {
        spawner.SetActive(true);      
        conveyor.enabled = true;      

        // Jumpstart the factory! 
        // This reaches into the spawner and forces it to drop the very first item.
        spawner.GetComponent<ConveyorSpawner>().SpawnObject();
    }

    public void StopSystem()
    {
        spawner.SetActive(false);     
        conveyor.enabled = false;     
    }
}