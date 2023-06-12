using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    public GameObject NewGameMenu;
    public GameObject loadingScreen;
    public Slider slider;
    public void LoadLevel() //загрузка лвла (лвл указан через ключ) скрипт где-то на ютубе брал
    {
        StartCoroutine(LoadAsynchronously(PlayerPrefs.GetInt("lvlkey", 3)));
    }

    public IEnumerator LoadAsynchronously(int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        loadingScreen.SetActive(true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / .9f);
            slider.value = progress;
            //Debug.Log(progress);

            yield return null;
        }
    }
    public void NonMenuLoadLevel() //загрузка лвла не в меню
    {
        if (PlayerPrefs.HasKey("ruLangKey"))
        {
            StartCoroutine(LoadAsynchronously(2));
        }
        else
        {
            StartCoroutine(LoadAsynchronously(1));
        }
            
    }

    public void NewGame()
    {
        PlayerPrefs.DeleteKey("lvlkey");
        StartCoroutine(LoadAsynchronously(3));
        NewGameMenu.SetActive(false);
    }

    public void firstlvlload()
    {
        {
            StartCoroutine(LoadAsynchronously(3));
        }
    }
}

