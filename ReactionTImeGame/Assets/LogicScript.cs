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
    // Start is called before the first frame update
    void Start()
    {
        randomtime = Random.Range(3, 20);
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
        Time.timeScale += 1;
        clicktime = false;
    }
    
    void spawnPipe()
    { 
        bonk.Play();
        clickButton.SetActive(true);
        score.SetActive(true);
    }
}
