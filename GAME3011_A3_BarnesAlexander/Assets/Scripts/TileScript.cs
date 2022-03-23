using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    public bool SelectedB;
    public int Value, numNeighbours = 0, max;
    public GameObject Neighbour1, Neighbour2, Neighbour3, Neighbour4, gc, Outline;
    GameController gcs;
    TileScript ts1, ts2, ts3, ts4;
    public int n1n, n2n, n3n, n4n, tempint1, tempint2;
    public bool Onen, Twon, canPop, ones, twos, threes, fours;
    Image Tile;
    AudioSource audioData;
    // Start is called before the first frame update
    void Start()
    {
        max = 4;
        audioData = GetComponent<AudioSource>();
        gc = GameObject.FindGameObjectWithTag("MainCamera");
        gcs = gc.GetComponent<GameController>();

        Value = Random.Range(0, max);
        Tile = gameObject.GetComponent<Image>();
        if (Value == 1)
        {
            Tile.color = Color.blue;
        }
        if (Value == 2)
        {
            Tile.color = Color.red;
        }
        if (Value == 3)
        {
            Tile.color = Color.green;
        }
        if (Value == 0)
        {
            Tile.color = Color.cyan;
        }

        if (Value == 4)
        {
            Tile.color = Color.yellow;
        }

        if (Neighbour1 != null)
        {
            ts1 = Neighbour1.GetComponent<TileScript>();
        }
        if (Neighbour2 != null)
        {
            ts2 = Neighbour2.GetComponent<TileScript>();
        }
        if (Neighbour3 != null)
        {
            ts3 = Neighbour3.GetComponent<TileScript>();
        }
        if (Neighbour4 != null)
        {
            ts4 = Neighbour4.GetComponent<TileScript>();
        }

        // Pop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Value == 1)
        {
            Tile.color = Color.blue;
        }
        if (Value == 2)
        {
            Tile.color = Color.red;
        }
        if (Value == 3)
        {
            Tile.color = Color.green;
        }
        if (Value == 0)
        {
            Tile.color = Color.cyan;
        }
        if (Value == 4)
        {
            Tile.color = Color.yellow;
        }

        if (Neighbour1 != null)
            n1n = ts1.Value;
        else
            n1n = -1;
        if (Neighbour2 != null)
            n2n = ts2.Value;
        else
            n2n = -1;
        if (Neighbour3 != null)
            n3n = ts3.Value;
        else
            n3n = -1;
        if (Neighbour4 != null)
            n4n = ts4.Value;
        else
            n4n = -1;

        if (n1n == Value)
        {
            ones = true;
        } else
        {
            ones = false;
        }

        if (n2n == Value)
        {
            twos = true;
        }
        else
        {
            twos = false;
        }

        if (n3n == Value)
        {
            threes = true;
        }
        else
        {
            threes = false;
        }


        if (n4n == Value)
        {
            fours = true;
        }
        else
        {
            fours = false;
        }

        if (ones || twos || threes || fours)
        {
            numNeighbours = 1;
        }
        if ((ones && twos) || (ones && threes) || (ones && fours) || (twos && fours) || (twos && threes) || (fours && threes))
        {
            numNeighbours = 2;
        }
        if ((ones && twos && threes) || (ones && twos && fours) || (fours && twos && threes))
        {
            numNeighbours = 3;
        }

        if (ones && twos && threes && fours)
        {
            numNeighbours = 4;
        }
        if(!ones && !twos && !threes && !fours)
        {
            numNeighbours = 0;
        }

        if (numNeighbours >= 2)
        {
            canPop = true;
        }
        else
        {
            canPop = false;
        }

        if (ones && ts1.canPop)
        {
            canPop = true;
        }
    
        if (twos && ts2.canPop)
        {
            canPop = true;
        }
    
        if (threes && ts3.canPop)
        {
            canPop = true;
        }
  
        if (fours && ts4.canPop)
        {
            canPop = true;
        }

        if (SelectedB)
        {
            Outline.gameObject.SetActive(true);
        } else
        {
            Outline.gameObject.SetActive(false);
        }

        if (canPop)
        {
            SelectedB = false;
        }

    }

    public void Selected()
    {
        if (SelectedB)
        {
            if(ts1 != null)
            {
                if (ts1.SelectedB)
                {
                    tempint1 = Value;
                    tempint2 = ts1.Value;
                    Value = tempint2;
                    ts1.Value = tempint1;
                    SelectedB = false;
                    ts1.SelectedB = false;
                }
            }
            if (ts2 != null)
            {
                if (ts2.SelectedB)
                {
                    tempint1 = Value;
                    tempint2 = ts2.Value;
                    Value = tempint2;
                    ts2.Value = tempint1;
                    SelectedB = false;
                    ts2.SelectedB = false;
                }
            }
            if (ts3 != null)
            {
                if (ts3.SelectedB)
                {
                    tempint1 = Value;
                    tempint2 = ts3.Value;
                    Value = tempint2;
                    ts3.Value = tempint1;
                    SelectedB = false;
                    ts3.SelectedB = false;
                }
            }
            if (ts4 != null)
            {
                if (ts4.SelectedB)
                {
                    tempint1 = Value;
                    tempint2 = ts4.Value;
                    Value = tempint2;
                    ts4.Value = tempint1;
                    SelectedB = false;
                    ts4.SelectedB = false;
                }
            }
        }
       
        if (canPop)
        {
            Pop();

            canPop = false;
        } else
        {
            SelectedB = !SelectedB;
        }
       
     
        
    }

    public void Pop()
    {
        audioData.Play(0);
        canPop = false;
        if (ones)
        {
            if(ts1.numNeighbours>=2)
            ts1.tPop();

           // ts1.random();
        }
        if (twos)
        {
            
                ts2.rPop();

          //  ts2.random();
        }
        if (threes)
        {
            ts3.bPop();
           // ts3.random();
        }
        if (fours)
        {
            if (ts4.numNeighbours >= 2)
                ts4.lPop();

           // ts4.random();
        }


        random();
    }

   public void random()
    {
        Value = Random.Range(0, max);
        gcs.pScore += 10;
    }

    public void changeDiff()
    {
        Value = Random.Range(0, max);       
    }



    public void rPop()
    {
        if (canPop)
        {
            canPop = false;
            if (ones)
            {
                if (ts1.numNeighbours >= 2)
                    ts1.tPop();

                //  ts1.random();
            }
            if (twos)
            {

                ts2.rPop();

                // ts2.random();
            }
            if (threes)
            {
                ts3.bPop();
                //  ts3.random();
            }



            random();
        }
    }

    public void lPop()
    {
        if (canPop)
        {
            canPop = false;
            if (ones)
            {
                if (ts1.numNeighbours >= 2)
                    ts1.tPop();

                // ts1.random();
            }
            if (fours)
            {

                ts4.lPop();

                // ts4.random();
            }
            if (threes)
            {
                ts3.bPop();
                // ts3.random();
            }



            random();
        }
    }

    public void tPop()
    {
        if (canPop)
        {
            canPop = false;
            if (ones)
            {
                if (ts1.numNeighbours >= 2)
                    ts1.tPop();

                // ts1.random();
            }
            if (fours)
            {

                ts4.lPop();

                // ts2.random();
            }
            if (twos)
            {
                ts2.tPop();
                //  ts2.random();
            }



            random();
        }
    }

    public void bPop()
    {
        if (canPop)
        {
            canPop = false;
            if (threes)
            {
                if (ts3.numNeighbours >= 2)
                    ts3.bPop();

                // ts3.random();
            }
            if (fours)
            {

                ts4.lPop();

                //ts2.random();
            }
            if (twos)
            {
                ts2.tPop();
                //ts2.random();
            }



            random();
        }
    }
}
