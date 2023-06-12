using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SelectButton : MonoBehaviour
{
    

    public void Start()
    {
            EventSystem.current.SetSelectedGameObject(this.gameObject);
    }
        
}
