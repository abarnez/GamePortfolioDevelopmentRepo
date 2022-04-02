using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text difficultyText, playerSkillText;
    public sinewave pWave, hWave;
    public float gameTimer, allowance, waveTimer, sensFreq, sensAmp, pskReducerAmp, pskReducerFreq, pSkill;
    public int difficulty;
    public bool MatchA, MatchB;
    public GameObject gameOverCanvas;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        gameOverCanvas.SetActive(false);
        gameTimer = 30;
        sensFreq = 0.0006f;
        sensAmp = 0.006f;
        waveTimer = 5;
        difficulty = Random.Range(0,3);
        Debug.Log(difficulty);
    }

    // Update is called once per frame
    void Update()
    {
        playerSkillText.text = "Player Skill: " + pSkill + "/5";
        pskReducerAmp = pSkill / 1000;
        pskReducerFreq = pSkill / 10000;
        gameTimer -= Time.deltaTime;
        waveTimer -= Time.deltaTime;
        if(waveTimer <= -5)
        {
            waveTimer = 5;
        }
        if(gameTimer < 0)
        {
            Time.timeScale = 0;
            gameOverCanvas.SetActive(true);
        }
        if (Input.GetKey(KeyCode.A))
            {
            pWave.frequency -= sensFreq - pskReducerFreq;
            }
            if (Input.GetKey(KeyCode.D))
            {
            pWave.frequency += sensFreq - pskReducerFreq;
            }
            if (Input.GetKey(KeyCode.W))
            {
            pWave.ampliute += sensAmp - pskReducerAmp;
            }
            if (Input.GetKey(KeyCode.S))
            {
            pWave.ampliute -= sensAmp - pskReducerAmp;
            }
        
        if (difficulty == 0)
        {
            difficultyText.text = "Difficulty: Easy";
            allowance = 0.15f;
            pWave.speed = 1f;
            hWave.speed = 1f;
        }
        if (difficulty == 1)
        {
            difficultyText.text = "Difficulty: Medium";
            allowance = 0.1f;
            pWave.speed = 5f;
            hWave.speed = 5f;
        }
        if (difficulty == 2)
        {
            difficultyText.text = "Difficulty: Hard";
            allowance = 0.01f;
            if (waveTimer > 0)
            {
                pWave.speed = 10f;
                hWave.speed = 10f;
            } else
            {
                pWave.speed = -10f;
                hWave.speed = -10f;
            }
       
        }
       
            if(pWave.ampliute >= hWave.ampliute - allowance)
            {
                if (pWave.ampliute <= hWave.ampliute + allowance)
                {
                    MatchA = true;
                }
                else
                {
                    MatchA = false;
                }
            }
            else
            {
                MatchA = false;
            }
            if (pWave.frequency >= hWave.frequency - allowance)
            {
                if (pWave.frequency <= hWave.frequency + allowance)
                {
                    MatchB = true;
                }
                else
                {
                    MatchB = false;
                }
            }
            else
            {
                MatchB = false;
            }
        if (Input.GetKeyDown(KeyCode.H))
        {
            if (MatchA && MatchB)
            {
                Reset();
            }
        }
    }
    public void PlayAgain()
    {
     
        SceneManager.LoadScene("SampleScene");    
    }
    private void Reset()
    {
        gameTimer = 30;
        //play sound
        difficulty = Random.Range(0, 3);
        hWave.Reset();
        if(pSkill < 5)
        pSkill += 1;
    }
}
