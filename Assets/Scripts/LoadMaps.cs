using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadMaps : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Preloading the maps to select.
    public void PreLoad()
    {
        SceneManager.LoadSceneAsync("TestMap");
        SceneManager.LoadSceneAsync("House");
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
