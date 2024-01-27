using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private AudioSource GotHit;
    public int currentHealth = 20;
    public static bool amIDead = false;

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        GotHit.Play();

        if (currentHealth <= 0 && amIDead == false)
        {           
            Debug.Log("YOU DEAD: " + currentHealth);
            amIDead = true;
            
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      GotHit = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
