using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TileScript : MonoBehaviour
{
    public bool SelectedB;
    public int Value, numNeighbours = 0;
    public GameObject Neighbour1, Neighbour2, Neighbour3, Neighbour4;
    TileScript ts1, ts2, ts3, ts4;
    public int n1n, n2n, n3n, n4n;
    public bool Onen, Twon, canPop;
    Image Tile;
    // Start is called before the first frame update
    void Start()
    {

        Value = Random.Range(0, 4);
        Tile = gameObject.GetComponent<Image>();
        if(Value == 1)
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

        Pop();
    }

    // Update is called once per frame
    void Update()
    {
        if(Neighbour1 != null)
        n1n = ts1.Value;
        if (Neighbour2 != null)
            n2n = ts2.Value;
        if (Neighbour3 != null)
            n3n = ts3.Value;
        if (Neighbour4 != null)
            n4n = ts4.Value;
    }

    public void Selected()
    {
      //  if(!Twon)
        SelectedB = !SelectedB;

    }

    public void Pop()
    {


        if (Neighbour1 != null)
        {
            if (Onen)
            {
                Debug.Log(ts1.Value);
            }
            if (ts1.Value == Value)
            {
                numNeighbours += 1;              
                if(ts1.numNeighbours > 1)
                {
                    canPop = true;
                }
            }
        }

        if (Neighbour2 != null)
        {
            if (Onen)
            {
                Debug.Log(ts2.Value);
            }
            if (ts2.Value == Value)
            {
                numNeighbours += 1;
                if (ts2.numNeighbours > 1)
                {
                    canPop = true;
                }
            }
        }

        if (Neighbour3 != null)
        {
            if (Onen)
            {
                Debug.Log(ts3.Value);
            }
            if (ts3.Value == Value)
            {
                numNeighbours += 1;
                if (ts3.numNeighbours > 1)
                {
                    canPop = true;
                }
            }
        }

        if (Neighbour4 != null)
        {
            if (Onen)
            {
                Debug.Log(ts4.Value);
            }
            if (ts4.Value == Value)
            {
                numNeighbours += 1;
                if (ts4.numNeighbours > 1)
                {
                    canPop = true;
                }
            }
        }

        if (numNeighbours > 1)
        {
            canPop = true;
        }


    }
}
