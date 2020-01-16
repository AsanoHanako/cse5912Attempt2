using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public void LoadLevel(string nextLevel)
    {
        StaticSceneData.nextScene = nextLevel;
        SceneManager.LoadScene("LoadingScene");
    }

    public void QuitRequest()
    {
        Application.Quit();
    }
}
