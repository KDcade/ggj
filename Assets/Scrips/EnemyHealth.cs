using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    private AudioSource GotHit;
    public int currentHealth = 20;
    public static bool isEnemyDead = false;

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        GotHit.Play();

        if (currentHealth <= 0 && isEnemyDead == false)
        {           
            Debug.Log("DEAD: " + currentHealth);
            Destroy(transform.parent.gameObject);
            isEnemyDead = true;
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
