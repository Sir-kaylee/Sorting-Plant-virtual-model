using UnityEngine;

public class SortingSensor : MonoBehaviour
{
    public CylinderPusher pusher;
    public float delayTime = 0.4f;

    bool busy = false;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Item") && !busy)
        {
            busy = true;
            Invoke(nameof(ActivatePusher), delayTime);
        }
    }

    void ActivatePusher()
    {
        pusher.ActivatePusher();
        Invoke(nameof(ResetSensor), 1f);
    }

    void ResetSensor()
    {
        busy = false;
    }
}