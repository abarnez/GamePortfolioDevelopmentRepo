using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonHandler : MonoBehaviour
{
    public int ID;
    public GameObject neightbour0, neightbour1, neightbour2, neightbour3, neightbour4, neightbour5, neightbour6, neightbour7;
    int nID0, nID1, nID2, nID3, nID4, nID5, nID6, nID7;
    public Button self;
    // Start is called before the first frame update
    void Start()
    {
        self = gameObject.GetComponent<Button>();
        self.onClick.AddListener(onClick);
        ID = int.Parse(gameObject.name);
        nID0 = ID - 33;
        nID1 = ID - 32;
        nID2 = ID - 31;
        nID3 = ID - 1;
        nID4 = ID + 1;
        nID5 = ID + 31;
        nID6 = ID + 32;
        nID7 = ID + 33;

      

        if (ID < 32 && ID >= 2)
        {
       
            neightbour3 = GameObject.Find("" + nID3);
            neightbour4 = GameObject.Find("" + nID4);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }
    
            
        if (ID == 1)
        {
            neightbour4 = GameObject.Find("" + nID4);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }
        if (ID == 32)
        {
            neightbour3 = GameObject.Find("" + nID3);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
        }
        else
        {
            neightbour0 = GameObject.Find("" + nID0);
            neightbour1 = GameObject.Find("" + nID1);
            neightbour2 = GameObject.Find("" + nID2);
            neightbour3 = GameObject.Find("" + nID3);
            neightbour4 = GameObject.Find("" + nID4);
            neightbour5 = GameObject.Find("" + nID5);
            neightbour6 = GameObject.Find("" + nID6);
            neightbour7 = GameObject.Find("" + nID7);
        }
        for (int i = 0; i < 32; i++)
        {
            if (ID == 1 + 32 * i)
            {
                //Debug.Log(1 + 32 * i);
                neightbour0 = null;
                neightbour1 = GameObject.Find("" + nID1);
                neightbour2 = GameObject.Find("" + nID2);
                neightbour3 = null;
                neightbour4 = GameObject.Find("" + nID4);
                neightbour5 = null;
                neightbour6 = GameObject.Find("" + nID6);
                neightbour7 = GameObject.Find("" + nID7);
            }
        }
        for (int i = 0; i < 33; i++)
        {
            if (ID == 0 + 32 * i)
            {
                Debug.Log(0 + 32 * i);

                neightbour0 = GameObject.Find("" + nID0);
                neightbour1 = GameObject.Find("" + nID1);
                neightbour2 = null;
                neightbour3 = GameObject.Find("" + nID3);
                neightbour4 = null;
                neightbour5 = GameObject.Find("" + nID5);
                neightbour6 = GameObject.Find("" + nID6);
                neightbour7 = null;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void onClick()
    {
        if(neightbour0 != null)
        {
            neightbour0.SetActive(false);
        }
        if (neightbour1 != null)
        {
            neightbour1.SetActive(false);
        }
        if (neightbour2 != null)
        {
            neightbour2.SetActive(false);
        }
        if (neightbour3 != null)
        {
            neightbour3.SetActive(false);
        }
        if (neightbour4 != null)
        {
            neightbour4.SetActive(false);
        }
        if (neightbour5 != null)
        {
            neightbour5.SetActive(false);
        }
        if (neightbour6 != null)
        {
            neightbour6.SetActive(false);
        }
        if (neightbour7 != null)
        {
            neightbour7.SetActive(false);
        }
        gameObject.SetActive(false);

    }


}
