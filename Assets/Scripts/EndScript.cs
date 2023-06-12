using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour
{
    public GameObject stscene;
    public GameObject ndscene;
    public GameObject UaStscene;
    public GameObject UaNdscene;
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("UaLangKey"))
        {
            UaStscene.SetActive(true);
        }
        else
        {
            stscene.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public void NextBtn()
    //{
    //    if (PlayerPrefs.HasKey("ruLangKey"))
    //    {
    //        RuStscene.SetActive(false);
    //        RuNdscene.SetActive(true);
    //    }
    //    else
    //    {
    //        stscene.SetActive(false);
    //        ndscene.SetActive(true);
    //    }
    //}
}
