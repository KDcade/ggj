using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCollider : MonoBehaviour
{
    
    private void OnTriggerStay(Collider Player)
    {
        if(Player.tag == "Player")
        {
            if (Input.GetButtonDown("nextLevel"))
            {
                FindObjectOfType<gameManager>().LoadNextScene();
            }
        }
    }
}
