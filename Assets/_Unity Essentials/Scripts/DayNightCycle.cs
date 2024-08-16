using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // The duration in seconds for a full day to pass
    [Tooltip("Duration in seconds for a full day to pass")]
    public float dayDuration = 60f;

    private float rotationSpeed;

    void Start()
    {
        // Calculate the rotation speed based on the duration
        rotationSpeed = 360f / dayDuration;
    }

    void Update()
    {
        // Rotate the light based on the rotation speed
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime, Space.Self);
    }
}
