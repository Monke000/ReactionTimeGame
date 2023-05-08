using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public float timer = 0;
    public float randomtime = 1;
    public bool clicktime = false;
    public GameObject clickButton;
    public GameObject joen2;
    public float timer2 = 0;
    public AudioSource bonk;
    public Text scoreText;
    public GameObject score;
    public GameObject retry;
    public int endscore = 1000;
    public int nextSceneToLoad;
    public GameObject menuButton;
    public bool isplay? = false;
    // Start is called before the first frame update
    void Start()
    {
        randomtime = Random.Range(3, 11);
    }

    // Update is called once per frame
    void Update()
    {
        if (clicktime == true)
        { 
            timer2 += Time.deltaTime;
            scoreText.text = timer2.ToString();
        }
        if (timer > randomtime)
        {
            spawnPipe();
            clicktime = true;
            randomtime = 10000000;
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    public void joen()
    {
        clicktime = false;
        retry.SetActive(true);
        menuButton.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void spawnPipe()
    { 
        bonk.Play();
        clickButton.SetActive(true);
        score.SetActive(true);
    }
    public void Play()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(nextSceneToLoad);
    }
    public void Menu()
    {
        nextSceneToLoad = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(nextSceneToLoad);
    }
}
