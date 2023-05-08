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

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.name == "Ball")
            {
                restartButton.SetActive(true);
            }
        }
    }
}
