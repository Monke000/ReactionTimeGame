using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunScript : MonoBehaviour
{

    private int nextSceneToLoad;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RunGame()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 2;
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
