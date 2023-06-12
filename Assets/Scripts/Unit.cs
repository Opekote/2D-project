using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public GameObject GameOverMenu;
    public GameObject UaGameOverMenu;
    

    
    public virtual void ReceiveDamage()
    {
        Die();
    }

    protected virtual void Die()
    {
        Destroy(gameObject);
    }

    public void PlayerDeath()
    {
        if (PlayerPrefs.HasKey("UaLangKey"))
        {
            UaGameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            //DeathEvent.Invoke();
            
            

        }
        else
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            //DeathEvent.Invoke();
            
            
        }

        
    }
}
