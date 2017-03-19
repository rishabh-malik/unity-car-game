using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    bool gameOver;
    public Text scoreText;
    int score;
        
	// Use this for initialization
	void Start () {
        score = 0;
        gameOver = false;
        InvokeRepeating("scoreUpdate",1.0f,0.5f);
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "Score:" + score;
        
	}
    void scoreUpdate()
    {
        if (!gameOver)
            score++;
        else score = 0;

    }
    public void gameover()
    {
        gameOver = true;
    }

    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
    }
    public void play()
    {
        SceneManager.LoadScene(1);
    }
}
