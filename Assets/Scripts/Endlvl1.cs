using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Endlvl1 : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider slider;
    private void OnTriggerEnter2D(Collider2D collision) //загрузка след. лвла при входе в тригер
    {
        {
            StartCoroutine(LoadAsynchronously(SceneManager.GetActiveScene().buildIndex + 1));
        }

        IEnumerator LoadAsynchronously(int sceneIndex)
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
    }

   
}
