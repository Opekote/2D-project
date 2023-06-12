using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("test", 100);
        Debug.Log(PlayerPrefs.GetInt("test", 200));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
