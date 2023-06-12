using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class SelectButtonIfPress : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton9))
        {
            EventSystem.current.SetSelectedGameObject(
                     this.gameObject);
        }

       
    }
}
