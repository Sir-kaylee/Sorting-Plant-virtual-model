using UnityEngine;

public class SensorBeep : MonoBehaviour
{
    public AudioSource beepSound;

    void OnTriggerEnter(Collider other)
    {
        beepSound.Play();
    }
}