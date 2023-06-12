using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeLangInMenu : MonoBehaviour
{
   public void ChangeLangToEng()
    {
        PlayerPrefs.DeleteKey("UaLangKey");
        int engLangInt = 0;
        PlayerPrefs.SetInt("engLangKey", engLangInt);
        SceneManager.LoadSceneAsync("Menu");
        int LangSetted = 0;
        PlayerPrefs.SetInt("LangExist", LangSetted);
    }

    public void ChangeLangToUa()
    {
        PlayerPrefs.DeleteKey("engLangKey");
        int UaLangInt = 1;
        PlayerPrefs.SetInt("UaLangKey", UaLangInt);
        SceneManager.LoadSceneAsync("Menu(ua)");
        int LangSetted = 1;
        PlayerPrefs.SetInt("LangExist", LangSetted);
    }
   
}
