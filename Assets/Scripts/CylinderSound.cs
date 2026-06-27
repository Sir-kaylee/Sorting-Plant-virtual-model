using UnityEngine;

public class CylinderSound : MonoBehaviour
{
    public AudioSource extendSound;
    public AudioSource retractSound;

    public void Extend()
    {
        extendSound.Play();
    }

    public void Retract()
    {
        retractSound.Play();
    }
}