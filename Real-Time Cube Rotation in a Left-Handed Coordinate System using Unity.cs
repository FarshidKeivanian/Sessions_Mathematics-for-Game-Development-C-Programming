using UnityEngine;

public class RotateCube : MonoBehaviour
{
    void Update()
    {
        // Rotate the cube around the Z-axis in a left-handed coordinate system
        transform.Rotate(0, 0, 45 * Time.deltaTime);
    }
}
