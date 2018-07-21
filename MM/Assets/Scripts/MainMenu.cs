/* The use of this code is to set functions to the buttons of the main menu
 * Created: 6/22/2018
 * Coded By: Alex Bishop
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Used for changing scenes
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    // Fade out animator
    public Animator LevelFader;

    // Starts the game from the intro
    public void PlayGame ()
    {
        // Play fade out animation
        LevelFader.SetTrigger("fadeOut");
        StartCoroutine("waitASec");
     
       
        // Calls the scene manager to get active scene index + 1
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Exits the game
    public void QuitGame ()
    {
        // Play fade out animation
        LevelFader.SetTrigger("fadeOut");
        StartCoroutine("waitASec");

        // Log exit and exit program
        Debug.Log("The user quit the application");
        Application.Quit();
    }

    // Coroutine that waits one second
    // We will use this to wait out the fadeOut animation
    IEnumerator waitASec()
    {
        yield return new WaitForSeconds(1);
    }
}
