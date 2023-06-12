using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject StartMenu;
    public GameObject NewGameMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        
        //bool check = PlayerPrefs.HasKey("lvlkey");
        if (!PlayerPrefs.HasKey("lvlkey"))
        {
            StartMenu.SetActive(true);
        }
        else
        {
            NewGameMenu.SetActive(true);
            StartMenu.SetActive(false);
        }

    }

}
