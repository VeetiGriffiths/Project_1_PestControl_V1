using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCreatedByBallCollidingWithEnemyWaspsNest : MonoBehaviour
{
    public AudioClip hitSound; // Sound effect to play on collision
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("EnemyWaspsNest"))
        {
            audioSource.PlayOneShot(hitSound);
        }
    }
}
