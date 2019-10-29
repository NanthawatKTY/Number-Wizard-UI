using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadNextScene()
    {
        //int cuz SceneLoader is 1,2,3 or 4 integer
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;  //Scene we are on now
        SceneManager.LoadScene(currentSceneIndex + 1); //Cuz currentSceneIndex = 0 then +1+2+3+...+ X
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(0); //Load Start Scene [0] (index = 0)
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
