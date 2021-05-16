using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneLoader : MonoBehaviour
{
    // Start is called before the first frame update
   public void LoadStartScene()
    {
        SceneManager.LoadScene(0);
    }
    public void OnQuit()
    {
        Application.Quit();
    }
}
