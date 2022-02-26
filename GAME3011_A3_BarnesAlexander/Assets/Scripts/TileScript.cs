using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{
    public bool SelectedB;
    public int Value = 1;
    public GameObject Neighbour1, Neighbour2, Neighbour3, Neighbour4;
    TileScript ts1, ts2, ts3, ts4;
    public bool Onen, Twon;
    // Start is called before the first frame update
    void Start()
    {
        

        if (Neighbour1 != null)
            ts1 = Neighbour1.GetComponent<TileScript>();
        if (Neighbour2 != null)
            ts2 = Neighbour2.GetComponent<TileScript>();
        if (Neighbour3 != null)
            ts3 = Neighbour3.GetComponent<TileScript>();
        if (Neighbour4 != null)
        ts4 = Neighbour4.GetComponent<TileScript>();

        Pop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Selected()
    {
        if(!Twon)
        SelectedB = !SelectedB;

    }

    public void Pop()
    {
        if (Neighbour1 != null)
        {
            if (ts1.Value == Value)
            {
                Onen = true;
                Debug.Log("suk mudda");
                if (ts1.Onen)
                {
                    Twon = true;
                }
            }
        }
        if (Neighbour2 != null)
        {
            if (ts2.Value == Value)
            {
                Debug.Log("suk mudda");
                Onen = true;
                if (ts2.Onen)
                {
                    Twon = true;
                }
            }
        }
        if (ts3 != null)
        {
            if (ts3.Value == Value)
            {
                Onen = true;
                if (ts3.Onen)
                {
                    Twon = true;
                }
            }
        }
        if (ts4 != null)
        {
            if (ts4.Value == Value)
            {
                Onen = true;
                if (ts4.Onen)
                {
                    Twon = true;
                }
            }
        }
    }
}
