using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaspsNestComesToBallPlayer : MonoBehaviour
{
    public GameObject ball;    // Reference to the player ball

    public float speed = 3.0f; // Movement speed of the enemy

    private void Update()
    {
        // Calculate the direction towards the player ball
        Vector3 direction = ball.transform.position - transform.position;

        // Move the enemy towards the player ball
        transform.position = Vector3.MoveTowards(transform.position, ball.transform.position, speed * Time.deltaTime);

        // Rotate the enemy to face the player ball
        transform.rotation = Quaternion.LookRotation(direction);
    }
}
