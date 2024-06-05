using UnityEngine;

public class BouncingBall : MonoBehaviour
{
    public float amplitude = 1.0f;
    public float frequency = 1.0f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        float newY = amplitude * Mathf.Abs(Mathf.Sin(2 * Mathf.PI * frequency * Time.time));
        transform.position = startPosition + new Vector3(0, newY, 0);
    }
}
