using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnablesNextLevel : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Cup"))
        {
            // Move the main camera 150 units positively on the x axis
            Camera.main.transform.position += new Vector3(150f, 0f, 0f);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
