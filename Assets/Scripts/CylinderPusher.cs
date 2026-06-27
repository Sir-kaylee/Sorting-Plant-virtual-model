using UnityEngine;

public class CylinderPusher : MonoBehaviour
{
    public Rigidbody rod;

    public float extendDistance = 0.5f;
    public float speed = 2f;

    Vector3 startPos;
    Vector3 extendPos;

    bool pushing = false;

    void Start()
    {
        startPos = rod.position;
        extendPos = startPos + transform.right * extendDistance;
    }

    void FixedUpdate()
    {
        if (pushing)
        {
            rod.MovePosition(Vector3.MoveTowards(
                rod.position,
                extendPos,
                speed * Time.fixedDeltaTime
            ));

            if (Vector3.Distance(rod.position, extendPos) < 0.01f)
                pushing = false;
        }
        else
        {
            rod.MovePosition(Vector3.MoveTowards(
                rod.position,
                startPos,
                speed * Time.fixedDeltaTime
            ));
        }
    }

    public void ActivatePusher()
    {
        pushing = true;
    }
}