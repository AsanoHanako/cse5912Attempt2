using UnityEngine.SceneManagement;
using UnityEngine;

public class QuitButton : IButton
{
    public override void ButtonAction()
    {
        Application.Quit();
    }
}