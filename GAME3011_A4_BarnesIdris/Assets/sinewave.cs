using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinewave : MonoBehaviour
{
    public float ampliute = 1;
    public float frequency = 1;
    public float speed = 1;
    public LineRenderer myLine;
    public bool pCheck;
    public int Points;

    // Start is called before the first frame update
    void Start()
    {
        myLine = GetComponent<LineRenderer>();
        if (!pCheck)
        {
            
            ampliute += Random.Range(-1.0f, 1.0f);
            frequency += Random.Range(0.0f, 1.0f);
        }
    }
    public void Reset()
    {
        ampliute = 1.0f;
        frequency = 0.5f;
        ampliute += Random.Range(-1.0f, 1.0f);
        frequency += Random.Range(0.0f, 1.0f);
    }
    void Draw()
    {
        float xStart = 0;
        float tau = 2 * Mathf.PI;
        float xFinish = tau;

        myLine.positionCount = Points;
        for (int currentPoint = 0; currentPoint < Points; currentPoint++)
        {
            float progress = (float)currentPoint / (Points - 1);
            float x = Mathf.Lerp(xStart, xFinish, progress);
            float y = ampliute * Mathf.Sin(tau * frequency * x + Time.time * speed);
            myLine.SetPosition(currentPoint, new Vector3(x, y, 0));
        }
    }
    // Update is called once per frame
    void Update()
    {
        Draw();

        if (pCheck)
        {
            if (Input.GetKey(KeyCode.A))
            {
                frequency -= 0.0001f;
            }
            if (Input.GetKey(KeyCode.D))
            {
                frequency += 0.0001f;
            }
            if (Input.GetKey(KeyCode.W))
            {
                ampliute += 0.001f;
            }
            if (Input.GetKey(KeyCode.S))
            {
                ampliute -= 0.001f;
            }
        }
    }
}
