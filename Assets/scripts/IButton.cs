using UnityEngine;
using UnityEngine.UI;

public class IButton : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(ButtonAction);
    }

    public virtual void ButtonAction() { }
}
