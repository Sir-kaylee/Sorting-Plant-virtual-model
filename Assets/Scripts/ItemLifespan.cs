using UnityEngine;

public class ItemLifespan : MonoBehaviour
{
    [Header("Cleanup Settings")]
    [Tooltip("How many seconds before this object is destroyed?")]
    public float lifetime = 10f; 

    void Start()
    {
        // The Destroy function has a built-in timer! 
        // This tells Unity: "Destroy this specific object, but wait 'lifetime' seconds to do it."
        Destroy(gameObject, lifetime);
    }
}