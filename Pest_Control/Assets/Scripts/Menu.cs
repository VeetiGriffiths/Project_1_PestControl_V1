using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   public void Play()
    {
        // Load the next scene in the build order by getting the build index of the current scene and adding 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Update is called once per frame
    public void Quit()
    {
        // Quit the game
        Application.Quit();
        // Log a message to the console
        Debug.Log("Player Has Quit The Game");
    }
}
