using UnityEngine;

[RequireComponent(typeof(Collider))]
public class SimpleConveyor : MonoBehaviour
{
    public float speed = 2f;                 // Conveyor speed
    public Vector3 direction = Vector3.forward; // Conveyor movement direction

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rb = collision.rigidbody;

        if (rb != null && !rb.isKinematic)
        {
            Vector3 move = direction.normalized * speed;
            rb.linearVelocity = new Vector3(move.x, rb.linearVelocity.y, move.z);
        }
    }
}