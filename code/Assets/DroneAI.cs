using UnityEngine;

public class DroneAI : MonoBehaviour
{
    public bool isInvestigating = false;

    public void Distract(Vector3 noisePosition)
    {
        isInvestigating = true;
        transform.LookAt(new Vector3(noisePosition.x, transform.position.y, noisePosition.z));
        GetComponent<Renderer>().material.color = Color.yellow; // Visual cue
        Debug.Log("Drone is distracted!");
    }
}