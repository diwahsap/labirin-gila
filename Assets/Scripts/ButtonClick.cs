using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    public void Startt()
    {
        SceneManager.LoadScene("maze");
    }

    // start, quit, retry, mainmenu
    public void Quitt()
    {
        // quit app
        Application.Quit();
    }

    public void Retry()
    {
        SceneManager.LoadScene("maze");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("mainmenu");
    }
}
