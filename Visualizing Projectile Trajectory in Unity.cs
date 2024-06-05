using UnityEngine;

public class ProjectilePath : MonoBehaviour
{
    public float initialVelocity = 20.0f;
    public float launchAngle = 45.0f;
    public float gravity = 9.81f;

    void Start()
    {
        float launchAngleRad = launchAngle * Mathf.Deg2Rad;
        float totalTime = 2 * initialVelocity * Mathf.Sin(launchAngleRad) / gravity;
        int numPoints = 100;
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
        lineRenderer.positionCount = numPoints;

        for (int i = 0; i < numPoints; i++)
        {
            float t = i * totalTime / (numPoints - 1);
            float x = initialVelocity * Mathf.Cos(launchAngleRad) * t;
            float y = initialVelocity * Mathf.Sin(launchAngleRad) * t - 0.5f * gravity * t * t;
            lineRenderer.SetPosition(i, new Vector3(x, y, 0));
        }
    }
}
