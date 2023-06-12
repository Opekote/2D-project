using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Falling : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject RuGameOverMenu;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (PlayerPrefs.HasKey("ruLangKey"))
        {
            RuGameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }
        else
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }

    }
  
}