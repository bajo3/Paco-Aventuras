using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealtController : MonoBehaviour
{

    public static playerHealtController instance;
    public int currentHealth, maxHealth;

    private void Awake ()
    {
        instance = this;
    }
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        
    }

    public void DealDamage()
    {
        currentHealth--;
        if (currentHealth <= 0)
        {
            gameObject.SetActive(false);
        }

        UiController.instance.UpdatehealthDisplay();
    }
}
