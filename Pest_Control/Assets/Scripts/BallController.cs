using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    // References
    public Rigidbody rb;

    Camera mainCamera;

    //Ball Settings
    public float stopVelocity;

    public float shotPower;

    public float maxPower;

    //Flags
    bool isAiming;

    bool isIdle;

    bool isShooting;

    // World point at which the player is aiming (nullable)
    Vector3? worldPoint;

    int counter = 0;


    // Start is called before the first frame update
    void Awake ()
    {
        mainCamera = Camera.main;
        rb.maxAngularVelocity = 1000;
        isAiming = false;
    }

    // Update is called once per frame
    void Update()
    {
        // If the ball's velocity is below the stop threshold, process aiming and shooting
        if (rb.velocity.magnitude < stopVelocity)
        {
            processAim();

            // If the left mouse button is clicked and the ball is idle, set the aiming flag to true
            if (Input.GetMouseButtonDown(0))
            {
                if (isIdle) isAiming = true;
            }

            // If the left mouse button is released, set the shooting flag to true
                if (Input.GetMouseButtonUp(0))
            {
                isShooting = true;
            }
        }
    }

    void FixedUpdate()
    {
        // If the ball's velocity is below the stop threshold, stop the ball
        if (rb.velocity.magnitude < stopVelocity)
        {
            stop();
        }
        // If the shooting flag is true, shoot the ball
        if (isShooting)
        {
            Shoot(worldPoint.Value);
            isShooting = false;
        }
    }

    private void processAim()
    {
        // If the aiming flag is false and the ball is not idle, return
        if (!isAiming && !isIdle) return;

        // Cast a ray from the mouse position on the screen and get the point where the ray intersects with a collider
        worldPoint = CastMouseClickRay();

        // If no collider is hit, return
        if (!worldPoint.HasValue) return;
    }

    // Cast a ray from the mouse position on the screen and get the point where the ray intersects with a collider (nullable)
    private Vector3? CastMouseClickRay()
    {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit)) return hit.point;
        else return null;
    }

    // Stop the ball and set the idle flag to true
    private void stop()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;

        isIdle = true;
    }
    // Shoot the ball towards the given point
    private void Shoot(Vector3 point)
    {
        isAiming = false;

        Vector3 horizontalWorldPoint = new Vector3(point.x, transform.position.y, point.z);

        Vector3 direction = (horizontalWorldPoint - transform.position).normalized;
        float strength = Vector3.Distance(transform.position, horizontalWorldPoint);
        rb.AddForce(direction * strength * shotPower);
        counter = counter + 1;
        Debug.Log(counter);
    }
}
