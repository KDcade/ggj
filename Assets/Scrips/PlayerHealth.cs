using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private AudioSource GotHit;
    public int currentHealth = 20;
    public static bool amIDead = false;

    private bool hasDoneDmg = false;
[SerializeField] float dmgDelay;
[SerializeField] float range = 5;
private int damage = 5;

    public void TakeDamage(int damage)
    {
        currentHealth = currentHealth - damage;
        GotHit.Play();

        if (currentHealth <= 0 && amIDead == false)
        {           
            Debug.Log("YOU DEAD: " + currentHealth);
            amIDead = true;
            Destroy(gameObject);
            
        }
    }

    IEnumerator OnTriggerStay(Collider damagebox)
    {
        if(damagebox.tag == "damagebox")
        {
            if(hasDoneDmg == false)
            {
                currentHealth = currentHealth - damage;
                GotHit.Play();
                hasDoneDmg = true;
                yield return new WaitForSeconds(dmgDelay);
                hasDoneDmg = false;

                 if (currentHealth <= 0 && amIDead == false)
                {           
                    Debug.Log("YOU DEAD: " + currentHealth);
                    amIDead = true;
                    Destroy(gameObject);
            
                }
            }
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
