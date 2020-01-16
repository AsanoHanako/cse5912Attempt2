using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadingScreenObjectGenerator : MonoBehaviour
{
    public GameObject prefab0;
    public GameObject prefab1;

    private GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        prefab = null;
        SetPrefab();
    }

    void SetPrefab()
    {
        int decision = Random.Range(0, 2);
        switch (decision)
        {
            case 0:
                prefab = prefab0;
                break;
            case 1:
                prefab = prefab1;
                break;
            default:
                Debug.Log("Prefab failed to load.");
                break;
        }
        Instantiate(prefab);
    }
}
