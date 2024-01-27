using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    
    public Transform target;
	public float speed = 2f;
	public Rigidbody rb;

    void FollowPlayer()
    {	
         Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        rb.MovePosition(pos);
       	transform.LookAt(target);
    }
    
    void OnTriggerStay(Collider player)
    {
	  		if(player.tag == "Player")
            {
	    	   FollowPlayer();
	    	}
	}
}

