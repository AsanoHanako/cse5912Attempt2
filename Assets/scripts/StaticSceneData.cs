using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class StaticSceneData
{
    public static string nextScene;

    public static string GetNextScene
    {
        get
        {
            return nextScene;
        }
        set
        {
            nextScene = value;
        }
    }
}
