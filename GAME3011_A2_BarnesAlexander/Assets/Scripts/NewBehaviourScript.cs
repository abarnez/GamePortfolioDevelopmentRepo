using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject keyHole;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.z <= 90 + 1)
        {
            if (transform.rotation.eulerAngles.z >= 90 - 1) {
                if (Input.GetKey(KeyCode.A))
                {
                    keyHole.transform.Rotate(new Vector3(0, 50, 0) * Time.deltaTime);
                    Debug.Log(transform.rotation.eulerAngles.z);
                }
                if (Input.GetKey(KeyCode.D))
                {
                    keyHole.transform.Rotate(new Vector3(0, -50, 0) * Time.deltaTime);
                    Debug.Log(transform.rotation.eulerAngles.z);
                }
            }
        }
        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
