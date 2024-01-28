using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextColliderLast : MonoBehaviour
{
    
    private bool yes = true;

    private void OnTriggerStay(Collider Player)
    {
        if(Player.tag == "Player")
        {
            if (yes == true);
            {
                FindObjectOfType<gameManager>().LoadNextScene();
            }
        }
    }
}
