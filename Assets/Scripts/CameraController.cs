using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class CameraController : MonoBehaviour
{
    public AudioSource audiosource;
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject UapauseMenuUI;
    

    [SerializeField]
    public float speed = 3.00F;

    [SerializeField]
    private Transform target;

    private void Start()
    {
        
        GameIsPaused = false;
    }
    private void Awake()
    {
        if (!target) target = FindObjectOfType<Character>().transform;
    }

    private void Update()
    {
        Vector3 position = target.position; position.z = -10.0F;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);

        if (GameIsPaused)
        {
            Cursor.visible = true;
            //audiosource.Stop();
        }
        else
        {
            Cursor.visible = false;
            //audiosource.Play();
        }

        //Pause menu and mouse
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();

            }

            

        }
        //Gamepad menu
        if (Input.GetKeyDown(KeyCode.JoystickButton7))
        {
            if (GameIsPaused)
            {
                Resume();

            }
            else
            {
                Pause();

            }



        }


    }
    public void Resume()
    {
        if (PlayerPrefs.HasKey("UaLangKey"))
        {
            UapauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            audiosource.Play();
        }
        else
        {
            pauseMenuUI.SetActive(false);
            Time.timeScale = 1f;
            GameIsPaused = false;
            audiosource.Play();
        }
        
    }

    public void Pause()
    {
        if (PlayerPrefs.HasKey("UaLangKey"))
        {
            UapauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            audiosource.Stop();
        }
        else
        {
            pauseMenuUI.SetActive(true);
            Time.timeScale = 0f;
            GameIsPaused = true;
            audiosource.Stop();
        }
    }

    public void LoadMenu()
    {
        if (PlayerPrefs.HasKey("UaLangKey"))
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu(ua)");
        }
        else
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
        ;
    }

   public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting game...");
    }

    //public void Mouse()
    //{
    //    Cursor.visible = true;
    //}
}
