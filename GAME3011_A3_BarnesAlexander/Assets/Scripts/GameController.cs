using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject tile1, tile2, tile3, tile4;
    public Vector3 pos1, pos2;
    TileScript t1, t2;
    // Start is called before the first frame update
    void Start()
    {
        t1 = tile1.GetComponent<TileScript>();
        t2 = tile2.GetComponent<TileScript>();
        pos1 = tile1.transform.position;
        pos2 = tile2.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        if(t1.SelectedB && t2.SelectedB)
        {
            Swap();
        }

    }

    void Swap()
    {
        tile1.transform.position = pos2;
        tile2.transform.position = pos1;
        pos1 = tile1.transform.position;
        pos2 = tile2.transform.position;
        t1.SelectedB = false;
        t2.SelectedB = false;

    }
}
