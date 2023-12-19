using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiringProjectile : MonoBehaviour
{
    public Transform launchPoint;
    public GameObject normalProjectilePrefab;
    public GameObject stunProjectilePrefab;
    public float launchVelocity = 10f;
    public float velocityChangeAmount = 2f; // Change in velocity per key press

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectilePrefab = Random.Range(0f, 1f) < 0.5f ? normalProjectilePrefab : stunProjectilePrefab;

            var projectile = Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);
            projectile.GetComponent<Rigidbody>().velocity = launchPoint.up * launchVelocity;
        }

        // Increase velocity when 'E' is pressed
        if (Input.GetKeyDown(KeyCode.E))
        {
            launchVelocity += velocityChangeAmount;
        }

        // Decrease velocity when 'Q' is pressed
        if (Input.GetKeyDown(KeyCode.Q))
        {
            launchVelocity -= velocityChangeAmount;
            if (launchVelocity < 0f) // Ensure velocity doesn't go below 0
            {
                launchVelocity = 0f;
            }
        }
    }
}
