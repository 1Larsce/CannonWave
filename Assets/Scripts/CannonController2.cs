using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController2 : MonoBehaviour
{
    public float rotationSpeed = 50f;

    void Update()
    {
        // Rotation of its Cannon "Vertical"
        float verticalInput = Input.GetAxis("Vertical");
        RotateCannon(verticalInput);
    }

    void RotateCannon(float input)
    {
        transform.Rotate(Vector3.left, input * rotationSpeed * Time.deltaTime);
    }
}
