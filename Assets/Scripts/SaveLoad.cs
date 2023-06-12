using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SaveGame();
        Debug.Log(PlayerPrefs.GetInt("lvlkey", 200));
    }
    
    public void SaveGame()
    {
        int lvlnumber = SceneManager.GetActiveScene().buildIndex;
        PlayerPrefs.SetInt("lvlkey", lvlnumber);
    }

    
}
