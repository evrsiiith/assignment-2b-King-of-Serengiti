using UnityEngine;

public class BottleLogic : MonoBehaviour
{
    public DroneAI drone;
    private bool isThrown = false;
    private bool hasShattered = false;

    // Built-in Unity method for mouse clicks!
    void OnMouseDown()
    {
        if (!isThrown)
        {
            isThrown = true;
            GetComponent<Rigidbody>().velocity = new Vector3(0, 3f, 5f); // Throw it forward
            Debug.Log("Bottle thrown!");
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (isThrown && !hasShattered && col.relativeVelocity.magnitude > 1f)
        {
            hasShattered = true;
            transform.localScale = new Vector3(0.1f, 0.05f, 0.1f); // Shrink to look shattered
            GetComponent<Rigidbody>().isKinematic = true;

            drone.Distract(transform.position); // Tell the drone!
        }
    }
}