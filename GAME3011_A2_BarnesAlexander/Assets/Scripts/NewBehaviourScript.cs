using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject keyHole;
    public int rand, playerSkill, difficultyLevel, keys;
    public float keyHealth, Timer, allowance;
    public Text timer, keyHP, keysLeft, pSkill, Difficulty;
    // Start is called before the first frame update
    void Start()
    {
        difficultyLevel = Random.Range(0, 4);
        rand = Random.Range(0, 180);
        keys = 3;
        keyHealth = 10;
        Timer = 60.0F;
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = "Time Remaining: " + Mathf.Round(Timer);
        keyHP.text = "Key Health: " + Mathf.Round(keyHealth);
        keysLeft.text = "Keys Remaining: " + keys;
        pSkill.text = "Skill Level: " + playerSkill;
        Difficulty.text = "Lock Difficulty: " + difficultyLevel;
        allowance = 0.1f + 3 - difficultyLevel;
        Timer -= Time.deltaTime;
            if (transform.rotation.eulerAngles.z <= rand + allowance)
            {
                if (transform.rotation.eulerAngles.z >= rand - allowance)
                {
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
   

        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                keyHealth -= Time.deltaTime;
                if (keyHealth < 0)
                {
                    breakKey();
                }

            }
            if (Input.GetKey(KeyCode.D))
            {
                keyHealth -= Time.deltaTime;
                if (keyHealth < 0)
                {
                    breakKey();
                }
            }
        }

        if (keyHole.transform.rotation.eulerAngles.x > 177 || keyHole.transform.rotation.eulerAngles.x < 0)
        {
            Debug.Log("Open");
            resetLock();
        }

        //rotation
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = 5.23f;

        Vector3 objectPos = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x = mousePos.x - objectPos.x;
        mousePos.y = mousePos.y - objectPos.y;

        float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        if (angle > 0 && angle < 180) {
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
    }


    void resetLock()
    {
        playerSkill += 1;
        difficultyLevel = Random.Range(0, 4);
        rand = Random.Range(0, 180);
        Timer = 60.0F;
        keyHole.transform.rotation = Quaternion.Euler(new Vector3(90, 0, 0));
    }

    void gameOver()
    {

    }

    void breakKey()
    {
        keys -= 1;
        keyHealth = 10;
    }
}
