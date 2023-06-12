using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SteamScript : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log(message: "Steam initalized: " + SteamManager.Initialized);
    }

   
}
