using UnityEngine;

public class Ladder : MonoBehaviour
{
    public float climbSpeed = 3f;

    [System.Obsolete]
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            // Get vertical input (W/S or Up/Down)
            float vertical = Input.GetAxis("Vertical");

            // Move player up/down
            rb.velocity = new Vector3(rb.velocity.x, vertical * climbSpeed, rb.velocity.z);

            // Optional: disable gravity while on ladder
            rb.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.useGravity = true;
        }
    }
}
