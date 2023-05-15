using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartMenu : MonoBehaviour
{
    public GameObject restartButton;

    // Start is called before the first frame update
    public void RestartGame()
    {
        SceneManager.LoadScene("Menu");
    }
    public class EnemyWaspsNest : MonoBehaviour
    {
        public GameObject restartButton;

         // This method is called when a collision occurs with another GameObject
        void OnCollisionEnter(Collision collision)
        {
            // If the collision with a GameObject named "Ball"
            if (collision.gameObject.name == "Ball")
            {
             // Set the restartButton to active
                restartButton.SetActive(true);
            }
        }
    }
}
