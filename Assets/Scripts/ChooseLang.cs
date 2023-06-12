using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseLang : MonoBehaviour
{
    public GameObject LanguageMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("LangExist"))
        {
            LanguageMenu.SetActive(true);
        }
        else
        {
            if (PlayerPrefs.HasKey("UaLangKey"))
            {
                SceneManager.LoadSceneAsync("Menu(ua)");
            }
            else
            {
                SceneManager.LoadSceneAsync("Menu");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UaLang()
    {
        int UaLangInt = 1;
        PlayerPrefs.SetInt("UaLangKey", UaLangInt);
        SceneManager.LoadSceneAsync("Menu(ua)");
        int LangSetted = 1;
        PlayerPrefs.SetInt("LangExist", LangSetted);
    }

    public void EngLang()
    {
        int engLangInt = 0;
        PlayerPrefs.SetInt("engLangKey", engLangInt);
        SceneManager.LoadSceneAsync("Menu");
        int LangSetted = 0;
        PlayerPrefs.SetInt("LangExist", LangSetted);
    }
}
