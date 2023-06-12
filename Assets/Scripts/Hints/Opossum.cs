using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opossum : MonoBehaviour
{
    public GameObject OpossumHint;
        // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        OpossumHint.SetActive(true);
        Time.timeScale = 0f;
    }

    void OK()
    {
        OpossumHint.SetActive(false);
        Time.timeScale = 1f;
    }
}
