using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    [SerializeField]
    Button startButton;

    void Start()
    {
        Time.timeScale = 0;
    }

    void OnEnable()
    {
        Time.timeScale = 0;
        startButton.onClick.AddListener(PlayGame);
    }

    void Update()
    {
        Time.timeScale = 0;
    }

    void PlayGame()
    {
        Time.timeScale = 1;
        gameObject.SetActive(false);
    }
}
