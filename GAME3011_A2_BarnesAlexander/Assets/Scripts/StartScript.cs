using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{
    public GameObject sceneObjects;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void close()
    {
        sceneObjects.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sceneObjects.SetActive(true);
        }
    }
}
