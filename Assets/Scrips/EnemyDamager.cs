using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamager : MonoBehaviour
{

private AudioSource Weh;

private bool hasDoneDmg = false;
[SerializeField] float dmgDelay;

private Transform enemy;
[SerializeField] float range = 5;
private int damage = 5;

    // Start is called before the first frame update
    void Start()
    {
        Weh = GetComponent<AudioSource>();
        enemy = GameObject.FindGameObjectWithTag("damagebox").transform; 
    }

    // Update is called once per frame
    void Update()
    {
    }
        void OnTriggerStay(Collider player)
        {
          if(player.tag == "Player")
          {
             if (hasDoneDmg == false)
             {
                //    StartCoroutine(Smacked());
                   HitCheck();
             }
          }
        }
    

 //   IEnumerator Smacked()
 //   {
 //       hasDoneDmg = true;
 //       yield return new WaitForSeconds(dmgDelay);
 //       hasDoneDmg = false;
 //   }

    IEnumerator HitCheck()
    {
        Ray rayFrom = new Ray(enemy.position, enemy.forward);
        RaycastHit hit;
        if (Physics.Raycast(rayFrom, out hit, range))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Debug.Log("GOT HIT!" + damage);
                hit.collider.GetComponent<PlayerHealth>().TakeDamage(damage);
                hasDoneDmg = true;
                yield return new WaitForSeconds(dmgDelay);
                hasDoneDmg = false;
                Weh.Play();
            }
            else
            {
                Debug.Log("eh?");
                Weh.Play();
            }
        }    
    }
}
