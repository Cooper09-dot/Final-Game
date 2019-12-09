using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Gives the ability to load into the game. 
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Quit game
    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
