//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;
//using UnityEngine.Audio;

//public class PauseMenu : MonoBehaviour
//{
//    public static bool GameIsPaused = false;
//    public GameObject pauseMenuUI;
//    public AudioSource audiosource;

//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Escape))
//        {
//            if (GameIsPaused)
//            {
//                Resume();

//            }
//            else
//            {
//                Pause();

//            }
//        }

//        if (Playerisdead)
//        {

//            audiosource.Stop();
//        }
//        else
//        {
//            Cursor.visible = false;

//        }
//    }

//    public void Resume()
//    {
//        pauseMenuUI.SetActive(false);
//        Time.timeScale = 1f;
//        GameIsPaused = false;
//        audiosource.Play();
//    }

//    public void Pause()
//    {
//        pauseMenuUI.SetActive(true);
//        Time.timeScale = 0f;
//        GameIsPaused = true;
//        audiosource.Stop();

//    }

//    public void LoadMenu()
//    {
//        Time.timeScale = 1f;
//        SceneManager.LoadScene(0);
//    }

//    public void QuitGame()
//    {
//        Application.Quit();
//        Debug.Log("Quiting game...");
//    }
//}
