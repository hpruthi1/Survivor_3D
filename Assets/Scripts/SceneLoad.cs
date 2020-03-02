using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoad : MonoBehaviour
{
    public void OnExitButtonClick()
    {
        Application.Quit();
    }

    public void OnRestartButtonClick()
    {
        SceneManager.LoadScene(0);
    }
    public void OnplayButtonClick()
    {
        SceneManager.LoadScene("Instructions");
    }

    public void OnContinueButtonClick()
    {
        SceneManager.LoadScene("Survivor");
    }
    public void PlayAgainButtonClick()
    {
        SceneManager.LoadScene(0);
    }

}
