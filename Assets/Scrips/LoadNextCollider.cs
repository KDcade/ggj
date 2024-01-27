using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadNextCollider : MonoBehaviour
{

    private void OnTriggerStay()
    {
        if (Input.GetButtonDown("nextLevel"))
        {
        FindObjectOfType<gameManager>().LoadNextScene();
        }
    }
}
