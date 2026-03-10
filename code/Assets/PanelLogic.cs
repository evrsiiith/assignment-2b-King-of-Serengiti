using UnityEngine;

public class PanelLogic : MonoBehaviour
{
    public DroneAI drone;
    public GameObject vaultDoor;
    private bool isPressed = false;

    void OnMouseDown()
    {
        if (isPressed) return;
        isPressed = true;

        if (drone.isInvestigating)
        {
            // Success!
            vaultDoor.transform.Rotate(0, 90, 0);
            GetComponent<Renderer>().material.color = Color.green;
            Debug.Log("SUCCESS: Door Opened!");
        }
        else
        {
            // Fail!
            vaultDoor.GetComponent<Renderer>().material.color = Color.red;
            Debug.Log("FAILED: Door Locked!");
        }
    }
}