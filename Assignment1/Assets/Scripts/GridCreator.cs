using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GridCreator : MonoBehaviour
{
    public GameObject myButton;
    public Canvas GameScreen;
    public int i3;
    // Start is called before the first frame update
    void Start()
    {
        
        for (int i2 = 0; i2 < 32; i2++) {
            for (int i = 0; i < 32; i++)
            {
                i3++;
                GameObject childObject = Instantiate(myButton, new Vector3(i * 29.0F + 50.0f, 950 - 29.0f * i2, 0), Quaternion.identity) as GameObject;
                //childObject.transform.parent = GameScreen.transform;
                childObject.transform.SetParent(GameScreen.transform);
                childObject.name = "" + i3;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
