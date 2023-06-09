using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameTHS : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
     // finds the game object and sets it to not visible.
        GameObject restartButton = GameObject.FindGameObjectWithTag("RestartGameButton");
        restartButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // Define a public method called RestartGame()
    public void RestartGame()
    {
        // Load the "Version 8 1-05-2023 1" scene
        SceneManager.LoadScene("Version 8 1-05-2023 1");
    }
}
