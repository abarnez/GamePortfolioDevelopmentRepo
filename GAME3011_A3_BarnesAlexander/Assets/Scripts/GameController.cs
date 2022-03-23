using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject[] tiles;

    public int pScore, tScore;
    public Text pScoreText, gtText, tScoreText;
    public float gameTimer;
    public GameObject btn, wScreen;
    // Start is called before the first frame update
    void Start()
    {
        gameTimer = 60;
        tScore = 750;
        btn.SetActive(false);
        wScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;
        pScoreText.text = "Score: " + pScore;
        tScoreText.text = "Points Remaining: " + (tScore - pScore);
        gtText.text = "Time Remaining: " + Mathf.Round(gameTimer);

        if(gameTimer < 0)
        {
            btn.SetActive(true);
        }
        if(pScore >= tScore)
        {
            wScreen.SetActive(true);
        }
    }

    public void easy()
    {
    for(int i = 0; i < tiles.Length; i++)
        {
            TileScript ts;
            ts = tiles[i].gameObject.GetComponent<TileScript>();
            ts.max = 3;
            ts.changeDiff();
            pScore = 0;
            tScore = 500;
            gameTimer = 60;
        }
     
    }

    public void medium()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            TileScript ts;
            ts = tiles[i].gameObject.GetComponent<TileScript>();
            ts.max = 4;
            ts.changeDiff();
            pScore = 0;
            tScore = 750;
            gameTimer = 60;
        }

    }

    public void hard()
    {
        for (int i = 0; i < tiles.Length; i++)
        {
            TileScript ts;
            ts = tiles[i].gameObject.GetComponent<TileScript>();
            ts.max = 5;
            ts.changeDiff();
            pScore = 0;
            tScore = 1000;
            gameTimer = 60;
        }

    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
