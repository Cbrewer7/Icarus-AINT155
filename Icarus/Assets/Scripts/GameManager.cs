using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Will load the first level of the game
    public void StartButton()
    {
        SceneManager.LoadScene("Level01");
    }
    // Will close the game
    public void EndGame()
    {
        // the debug tool to check if it has worked
        Debug.Log("The application has been quit");
        Application.Quit();
    }
    // Back to main menu
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
}
