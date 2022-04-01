using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public sinewave pWave, hWave;
    public float gameTimer;
    public int difficulty, pSkill;
    public bool MatchA, MatchB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (difficulty == 0)
        {
            if(pWave.ampliute >= hWave.ampliute - 0.1)
            {
                if (pWave.ampliute <= hWave.ampliute + 0.1)
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
            if (pWave.frequency >= hWave.frequency - 0.1)
            {
                if (pWave.frequency <= hWave.frequency + 0.1)
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
        }
        
    }
}
