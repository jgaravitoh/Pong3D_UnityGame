using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Pong"); //main game scene
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
