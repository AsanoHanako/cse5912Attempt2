using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class StartButton : IButton
{
    public override void ButtonAction()
    {
        SceneManager.LoadSceneAsync("GameScene1", LoadSceneMode.Single);
    }
}
