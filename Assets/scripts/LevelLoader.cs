using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public Slider slider;
    public Text loadingMessagesText;

    private AsyncOperation operationStatus;

    void Start()
    {
        StartCoroutine(LoadAsynchronouslyCoroutine());
    }
    private IEnumerator LoadAsynchronouslyCoroutine()
    {
        operationStatus = SceneManager.LoadSceneAsync(StaticSceneData.GetNextScene);
        operationStatus.allowSceneActivation = false;

        while (!operationStatus.isDone)
        {
            float progress = Mathf.Clamp01(operationStatus.progress / 0.9f);
            slider.value = progress;

            if (progress >= 0.95f)
            {
                loadingMessagesText.text = "Loading complete.\nPress Space to continue.";

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    operationStatus.allowSceneActivation = true;
                }
            }

            yield return null;
        }
    }
}
