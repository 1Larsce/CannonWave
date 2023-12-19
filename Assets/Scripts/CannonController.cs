using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CannonController : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotation of its Cannon "Horizontal"
        float horizontalInput = Input.GetAxis("Horizontal");
        RotateCannon(horizontalInput);
    }

    void RotateCannon(float input)
    {
        transform.Rotate(Vector3.up, input * rotationSpeed * Time.deltaTime);
    }
}